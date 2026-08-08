/* 
* COMP 3271 - Computer Networks
* Project Part 2 - TCP Echo Client
* TCP socket implementation developed using the provided course starter code
* and concepts from IBM developer socket programming tutorial:
* https://developer.ibm.com/tutorials/l-sock
* All code was adapted and integrated into provided starter code
*/
// TCP echo client program
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>

#define	BUFFSIZE 512  // Maximum length of buffer

// Student Added Section Part 1 -- Helper function for error handling 
void Die(char *message)
{
  perror(message);
  exit(1);
}
int main (int argc, char* argv[ ]) // Three arguments to be checked later
{
        // Check for correct number of command line arguments
	if(argc != 4) {                                               
		Die("tcp-echo-client [IP address] [Port] [Message]\n");                             
	} 
	
	// Access argv elements safely after verifying cmd line args
	struct sockaddr_in servAddr;  // Server socket address data structure
	char *servIP = argv[1]; // Server IP address from command line
	int servPort = atoi(argv[2]); // Server port number from command line
	char *message = argv[3];  // Message specified on the command line
        int echo_len = strlen(argv[3]); // Size of the message specified on the command line
        int received = 0; // Initialize count for received data to 0 
        char buffer[BUFFSIZE]; // Buffer for response                                               

	// Populate socket address for the server
	memset (&servAddr, 0, sizeof(servAddr));  // Initialize data structure
	servAddr.sin_family = AF_INET;  // This is an IPv4 address
	servAddr.sin_addr.s_addr = inet_addr(servIP); 	// Server IP address
	servAddr.sin_port = servPort; // Server port number
	
	// Create a TCP socket stream
	int sock;
	if ((sock = socket (AF_INET, SOCK_STREAM, IPPROTO_TCP)) == -1) {
		Die("Error: socket creation failed!\n");
	}
	else
        printf("Socket successfully created..\n"); 

	// Connect to the server
	if ((connect (sock, (struct sockaddr*)&servAddr, sizeof(servAddr))) == -1) {
		Die("Error: connection to the server failed!\n");
	}
	 else
          printf("Connected to the server..\n"); 
	
	// Student Added Section Part 2 -- Client handling function 
	// Send data to the server...
        if (send(sock, message, echo_len, 0) != echo_len)
        {
          Die("Mismatch in number of bytes sent.");
        }
	printf("Sending message: %s\n", message);
	
	/* Receive data back from the server. Loop to continue receiving until the complete echoed 
	message has been received. TCP may split the transmitted data into multiple segments. */
	while (received < echo_len)
	{
	  int bytes = recv(sock, buffer + received, echo_len - received, 0);
	  if (bytes < 1)
	  {
	    Die("Failed to receive bytes from the server.");
	  }
	  
	  received += bytes;
	} // end-while loop
	
	buffer[received] = '\0'; 
	// print data...
	printf("Received: %s\n", buffer);
	
        fprintf(stdout, "\n");
	// Close socket
	close (sock);
	
	// Stop program
	exit (0);
} // End main
