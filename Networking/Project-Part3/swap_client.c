/*
*	swap_client.c
* Citations:
* Stop and Wait Reference:
* Reference: Stop-and-Wait Protocol (taken from section 23.2.2 of the 5th edition of the textbook)
* Checksum References:
* https://www.rfc-editor.org/info/rfc1071/
* https://re.factorcode.org/2010/09/internet-checksum.html

* Frame Layout: 
+-------+--------+------+---------+-------+
| Flag  | Header | Data | Trailer | Flag |
+-------+--------+------+---------+-------+
 Flag        = 1 byte, 01111110
 Header      = 2 bytes (type & seq number)
 Data        <= 128 bytes (MAXLINE)
 Trailer     = 2 bytes (checksum)
 Flag        = 1 byte, 01111110
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>

#define	MAXLINE 128	// maximum characters to receive and send at once
#define	MAXFRAME 256
#define HEADER_SIZE 2
#define DATA 1
#define ACK 2
#define CHECKSUM_SIZE 2
#define FLAG 0x7E // 01111110
#define ACK_TIMEOUT 5000


extern int swap_connect(unsigned int addr, unsigned short port);
extern int swap_disconnect(int sd);
extern int sdp_send(int sd, char *buf, int length);
extern int sdp_receive(int sd, char *buf);
extern int sdp_receive_with_timer(int sd, char *buf, unsigned int expiration);
extern unsigned short checksum(unsigned char buf[], int length);

int session_id = 0;
int S = 0;	// frame number sent

int swap_open(unsigned int addr, unsigned short port)
{
	int	sockfd;		// sockect descriptor
	struct	sockaddr_in	servaddr;	// server address
	char	buf[MAXLINE];
	int	len, n;

	/*
	*	if the session is already open, then return error
	*/

	if (session_id != 0)
		return -1;

	/*
	*	connect to a server
	*/

	session_id = swap_connect(addr, port);	// in sdp.o

	/*
	*	return the seesion id
	*/

	return session_id;
}

int swap_write(int sd, char *buf, int length)
{
	int n, frame_length;
	char frame[MAXFRAME];
	char ack_frame[MAXFRAME];
	unsigned char checksum_buf[MAXFRAME];
	static char saved_frame[MAXFRAME];
	static int saved_length;

	if (session_id == 0 || sd != session_id)
		return -1;

	// Payload must be 
	if (length > MAXLINE)
		return -1;

	/*
	*	send a DATA frame
	*/
	// Make a DATA frame.
	frame[0] = FLAG;
	frame[1] = DATA;

	// Set the sequence number to S.
	frame[2] = S;

	// Copy data into frame
	memcpy(&frame[3], buf, length);
	
	// Copy header + data into checksum buffer
	memcpy(checksum_buf, &frame[1], 2 + length);

	// Add the checksum length
	int checksum_length = (2 + length);
	
	// Check if header + data length is even or odd
	// Must be even for checksum function, so if odd, add temp padding
	if (checksum_length % 2 != 0)
	{
	  checksum_buf[checksum_length] = 0; // pad with a 0 to make the checksum buffer even
	  checksum_length++; // Increment checksum length to deal w/ extra byte
	}
        
        // Call checksum with buffer for checksum and checksum length
	unsigned short sum = checksum(checksum_buf, checksum_length);
	
	// Shift to drop bottom 1 byte 
	frame[3 + length] = sum >> 8;
	
	// Use bitwise AND to drop top 1 byte
	frame[4 + length] = sum & 0xff;

        // Set the flag
	frame[5 + length] = FLAG;
        
	frame_length = 6 + length;

	// Save a copy of the frame (needed in case it must be resent).
	memcpy(saved_frame, frame, frame_length);
	saved_length = frame_length;

	// Send the frame using sdp_send()
	sdp_send(sd, frame, frame_length);

	while (1) 
	{
	    // Wait for an ACK using sdp_receive_with_timer().
	    n = sdp_receive_with_timer(sd, ack_frame, ACK_TIMEOUT);
            
		// Several different cases including disconnection
		if (n == -3) 
		{
			// Timeout. Resend the saved DATA frame. 
			sdp_send(sd, saved_frame, saved_length);
			continue;
		}
		if (n == -2) 
		{
			// Session disconnected. Return error.
			return -1;
		}
		if (n < 0) 
		{
			// General error
			return -1;
		}
		
		// Check ACK type
		if (ack_frame[1] != ACK)
		{
			continue;
		}
		
		// Verify ACK checksum
		unsigned char ack_checksum_buf[2];

		ack_checksum_buf[0] = ack_frame[1];
		ack_checksum_buf[1] = ack_frame[2];
		
		unsigned short ack_sum = checksum(ack_checksum_buf, 2);

		unsigned short received_sum;
		received_sum = ((unsigned char)ack_frame[3] << 8) | (unsigned char)ack_frame[4];

		// If bad checksum, continue
		if (ack_sum != received_sum)
			continue;
		
		// Verify ACK Number
		if (ack_frame[2] != ((S + 1) % 2))
			continue;

		// Successful ACK
		S = (S + 1) % 2;
		
		/*
		* return the length sent
		*/
		return length;
	}
}

void swap_close(int sd)
{
	if (session_id == 0 || sd != session_id)
		return;

	else
		session_id = 0;

	swap_disconnect(sd);	// in sdp.o
}
