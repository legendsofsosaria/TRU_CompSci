/* fta_client.c
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
extern int swap_open(unsigned int addr, unsigned short port);
extern int swap_write(int sd, unsigned char buf[], int length);
extern void swap_close(int sd);
   
int main(int argc, char *argv[])
{
	unsigned short server_port;
	unsigned int server_address;
	unsigned char buf[MAXLINE];
	int sd, n, in;
	char *src_filename; // Added Source file name
	char *dest_filename; // Added Destination file name

        /* ----- STUDENT SECTION -----
        Student updated usage statement to include arguments 
        for src and destination file names */
	if (argc < 5) {
		fprintf(stderr, "Usage: %s address port src-filename dest-filename\n", argv[0]);
		exit(1);
	}
	
	// set values for server address and port number
	server_address = inet_addr(argv[1]);	// server address
	server_port = htons(atoi(argv[2]));		// port number
	
	/* ----- STUDENT SECTION -----
	Student added values set for the source and destination file names from args */
        src_filename = argv[3];
        dest_filename = argv[4];
        
	// connect to the swap server
	sd = swap_open(server_address, server_port);
	if (sd < 0) {
		fprintf(stderr, "swap_open error\n");
		exit(0);
	}
	
	/* ----- STUDENT SECTION ----- */
	//open input file for reading
	in = open(src_filename, O_RDONLY);
	printf("Opening input file %s for reading..\n", src_filename);
	
	// Handle file read error
	if (in < 0)
	{
	  perror("Error in reading file.");
	  exit(1);
	}
	  
	//send destination file name to the server
        swap_write(sd, dest_filename, strlen(dest_filename) + 1);
        printf("Sending destination file name %s to the server\n", dest_filename);
        
	// loop
	printf("Reading file data\n");
	while ((n = read(in, buf, MAXLINE)) > 0) 
	{
	    //while there is data in the file, send it to the server
	    swap_write(sd, buf, n);
            printf("Sending file data to the server...\n"); 
	}
	// end-loop, end student section
		
	// close the connection to the swap server		
	swap_close(sd);

	//close connection to input file
	close(in);
}
