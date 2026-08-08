/* 
* COMP 3271 - Computer Networks
* Project Part 1 - UDP Time Server - client implementation 
*/

#include <stdio.h> /* I/O Functions */
#include <string.h> /* String functions */
#include <stdlib.h> /* C Standard Functions */
#include <sys/socket.h> /* Socket functions */
#include <sys/types.h> /* Library of basic types */
#include <netinet/in.h> /* Library of Internet address functions */
#include <arpa/inet.h> /* Internet operations */
#include <time.h> /* Time functions */

#define BUFFSIZE 200 /* Buffer size */

int main(int argc, char *argv[])
{
	int sockfd;
	int addrlen;
	char buffer[BUFFSIZE] = "Name: Elizabeth House Student ID: T00738901";
	struct sockaddr_in server;
	struct sockaddr_in client;
	char *servIP = argv[1]; // Server IP address from command line
	int servPort = atoi(argv[2]); // Server port number from command line
	time_t current_time;
	
	/* Check that two arguments were passed on the command line */
	if (argc != 3) {
		printf("Usage: udp-time-client [IP address] [Port] \n");
		exit(1);
	}

	/* Populate server socket data structure with IP address and port number */
	memset((char *) &server, 0, sizeof(server));
	server.sin_family = AF_INET;
	server.sin_port = htons(servPort);
	server.sin_addr.s_addr = inet_addr(servIP);

	/* Populate client socket data structure with IP address and port number */
	memset((void *)&client, '\0', sizeof(client));
	client.sin_family = AF_INET;
	client.sin_port = htons(servPort);
	client.sin_addr.s_addr = inet_addr(servIP);

	/* Create a UDP socket; returns -1 on failure */
	printf("Creating UDP Socket...\n");
	sockfd = socket(AF_INET, SOCK_DGRAM,0);
	if (sockfd == -1) {
		printf("Socket error\n");
		exit(1);
	}

	/* Helpful status message */
	printf("Client is connecting to server %s on port: %d\n", servIP, servPort);

	/* Send time request to server */
	addrlen = sizeof(struct sockaddr_in);
	printf("Preparing message request to server...\n");
	printf("Message Contents: %s\n", buffer);
	sendto(sockfd, buffer, (int)strlen(buffer) + 1, 0, (struct sockaddr *)&server, addrlen); 
	printf("Request sent to server\n");

	/* Receive time request from server */
	recvfrom(sockfd, buffer, BUFFSIZE, 0, (struct sockaddr *)&server, (socklen_t *)&addrlen);

	/* Print the time received from the server */
	printf("\n Response received from Server: \n%s\n", buffer);
	printf("Closing client socket...\n");
	exit(0);
}
/* End of time client program */
