/* 
* COMP 3271 - Computer Networks
* Project Part 1 - UDP Time Server - server implementation 
*/

#include <stdio.h> /* I/O Functions */
#include <string.h> /* String functions */
#include <stdlib.h> /* C Standard functions */
#include <sys/socket.h> /* Socket functions */
#include <sys/types.h> /* Library of basic types */
#include <netinet/in.h> /* Library of Internet address functions */
#include <arpa/inet.h> /* Internet operations */
#include <time.h> /* time functions */

#define PORT 9988 /* Server port */
#define BUFFSIZE 200 /* Buffer size */

int main()
{
	int sockfd;
	int addrlen;
	char buffer[BUFFSIZE];
	struct sockaddr_in server;
	struct sockaddr_in client;
	time_t current_time;
		
	/* Populate socket data structures with IP address and port number */
	memset((char *) &server, 0, sizeof(struct sockaddr_in));
	server.sin_family = AF_INET;
	server.sin_port = htons(PORT);

	/* Create a UDP socket; returns -1 on failure */
	printf("Creating UDP server socket...\n");
	sockfd = socket(AF_INET, SOCK_DGRAM,0);
	if (sockfd == -1) {
		printf("Socket error\n");
		exit(1); /* Exit on error */
	}

	/* Bind the socket address */
	printf("Binding server socket to port %d...\n", PORT);
	if ((bind(sockfd,(struct sockaddr*)&server,sizeof(struct sockaddr_in))) == -1) {
		printf("Server bind error\n");
		exit(1); /* exit on error */
	}

	/* Helpful status message */
	printf("Server is listening on port: %d\n", PORT);
	printf("Waiting for client request...\n");
	printf("Press CTRL + C to exit\n");

	while(1) {
		printf("Waiting to receive data from client...\n");
		addrlen = sizeof(struct sockaddr_in);
		recvfrom(sockfd, buffer,BUFFSIZE, 0,(struct sockaddr *)&client, (socklen_t *)&addrlen);
		printf("Received request from client\n");
		printf("Client Message: %s\n", buffer);
		current_time = time(NULL);
		strcat(buffer, "\n Current time: ");
		strcat(buffer, ctime(&current_time));
		printf("Sending current time back to client...\n");
		sendto(sockfd, buffer, strlen(buffer) + 1, 0, (struct sockaddr *)&client, addrlen);
		printf("Response sent successfully\n");
	}
	exit(0);
}
/* End of time server program */
