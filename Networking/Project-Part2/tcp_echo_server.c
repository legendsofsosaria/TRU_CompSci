/* 
* COMP 3271 - Computer Networks
* Project Part 2 - TCP Echo Server
* TCP socket implementation developed using the provided course starter code
* and concepts from IBM developer socket programming tutorial:
* https://developer.ibm.com/tutorials/l-sock
* All code was adapted and integrated into provided starter code
*/
//TCP Echo server program
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>

#define	BUFFSIZE 512  // Maximum length of buffer
#define PORT	9988  // Fixed server port number
#define MAXPENDING 5  // Maximum connection requests

// Student Added Section Part 1 -- Helper function for error handling 
void Die(char *message)
{
  perror(message);
  exit(1);
}

// Student Added Section Part 2 -- Client handling function 
void HandleClient(int client_sock)
{
  char buffer[BUFFSIZE];
  int received = -1;
  
  // Receive the message
  if ((received = recv(client_sock, buffer, BUFFSIZE, 0)) < 0) 
  {
    Die("Failed to receive initial data from client!");
  }
  // Send data and check for more incoming data in a loop 
  while (received > 0) 
    {
    // Send back the received data
      printf("Echoing data back to the client.\n");
      if (send(client_sock, buffer, received, 0) != received)
      {
	Die("Failed to send data to the client!");
      }
      
      printf("Received %d bytes from client.\n", received);
      
      if ((received = recv(client_sock, buffer, BUFFSIZE, 0)) < 0)
      {
	Die("Failed to receive additional data from client!");
      }
    }
    printf("Client disconnected.\n");
    close(client_sock);
}
int main (void)
{
	struct sockaddr_in server_address;  // Data structure for server address
	struct sockaddr_in client_address;  // Data structure for client address
	int client_sock; // Client socket
	
	// Populate socket address for the server
	memset (&server_address, 0, sizeof (server_address));	// Initialize server address data structure
	server_address.sin_family = AF_INET; // Populate family field - IPV4 protocol
	server_address.sin_port = PORT;	// Set port number
	server_address.sin_addr.s_addr = INADDR_ANY;  // Set IP address to IPv4 value for localhost
	 	
	// Create a TCP socket; returns -1 on failure
	int listen_sock; 
	if ((listen_sock = socket (AF_INET, SOCK_STREAM, IPPROTO_TCP)) == -1) 
	{
		Die("Error: Listen socket failed!\n");
	}

	// Bind the socket to the server address; returns -1 on failure
	if ((bind(listen_sock, (struct sockaddr *)&server_address, sizeof (server_address))) == -1) 
	{
		Die("Error: binding failed!\n");
	}
	printf("TCP Echo Server starting...\n");
	if (listen(listen_sock, MAXPENDING) < 0)
	{
	  Die("Failed to listen on server socket!");
	}
	
	printf("Server listening on port %d...\n", PORT);
	
	// Students to complete this section 
	while(1)
	{
	  printf("Waiting for client connection...\n");
	  unsigned int client_address_len = sizeof(client_address);
		
	  if ((client_sock = accept(listen_sock, (struct sockaddr *)&client_address, &client_address_len)) < 0)
	  {
	    Die("Failed to accept client connection!");
	  }

	  fprintf(stdout, "Client connected: %s\n", inet_ntoa(client_address.sin_addr));
	  HandleClient(client_sock);
	}
} // End main
