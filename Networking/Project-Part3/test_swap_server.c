#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>
#include <arpa/inet.h>

#define MAX_FTA	128

// External functions
extern int swap_wait(unsigned short port);
extern int swap_read(int sd, unsigned char buf[]);
extern void swap_close(int sd);

// These arguments must be passed to the program
// argv[1]: port number, e.g., "6789"

int main (int argc, char *argv[])
{
	int	sd, bytes_read;
	char	buf[MAX_FTA];

	if (argc < 2) {
		fprintf(stderr, "Usage: %s port_number\n", argv[0]);
		exit(1);
	}
        
        printf("Waiting for the client to connect on port %s.\n", argv[1]);
        
	sd = swap_wait(htons(atoi(argv[1])));
	if (sd < 0) {
		fprintf(stderr, "%s cannot wait, %d\n", argv[0], sd);
		exit(1);
	}
        
        printf("Client connected. Receiving messages...\n");
        
	// read message from the client and store them into the above file
	while((bytes_read = swap_read(sd, buf)) > 0) {
		buf[bytes_read] = '\0';
		printf("%s\n", buf);
	}

	// close the file and the connection
	printf("Disconnecting...\n");
	swap_close(sd);
}

