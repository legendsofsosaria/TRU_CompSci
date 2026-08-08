/* fta_server.c
* Elizabeth House
* T00738901
* Project Part 4
* References:
* https://www.geeksforgeeks.org/c/input-output-system-calls-c-create-open-close-read-write/
*/
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>
#include <arpa/inet.h>

#define	MAXLINE	128	// maximum bytes to receive and send at once

// External functions
extern int swap_wait(unsigned short port);
extern int swap_read(int sd, unsigned char buf[]);
extern void swap_close(int sd);

int main(int argc, char *argv[])
{
	unsigned short server_port;
	unsigned int server_address;
	unsigned char message[MAXLINE];
	int sd, n, out;
	unsigned char filename[MAXLINE]; // Added buffer for filename received from client

	if (argc < 2) {
		fprintf(stderr, "Usage: %s port\n", argv[0]);
		exit(1);
	}

	// set values for server address and port number
	server_port = htons(atoi(argv[1]));

	// connect to the port allocated to the swap server
	sd = swap_wait(server_port);
	if (sd < 0) {
		fprintf(stderr, "swap_open error\n");
		exit(0);
	}

	/* ----- STUDENT SECTION ----- */
	//read in the first message as the new name of the file
        n = swap_read(sd, filename);
        printf("Reading filename message from client: %s\n", filename);
        
	//open output file for writing, create if doesn't exist, w/ proper permissions
	out = open(filename, O_WRONLY | O_CREAT, 0644);
	printf("Opening output file for writing...\n");
	
	// Handle file opening error
	if (out < 0)
	{
	  perror("Error opening output file");
	  exit(1);
	}
	
	// loop, get the file data from the client until end-of-file
	printf("Reading data from client...\n");
	while ((n = swap_read(sd, message)) > 0) 
	{  
	  // Write the data to the file
	  write(out, message, n);
	  printf("Data written to file!\n");
	}
	//end-loop, end student section
	
	// close the connection to the swap servfer
	swap_close(sd);
	
	//close connection to output file
	close(out);
}
