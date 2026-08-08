/*
*	swap_server.c
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>

#define	MAXLINE	128	// maximum characters to receive and send at once
#define MAXFRAME 256
#define FLAG 0x7E // 01111110
#define ACK 2

extern int swap_accept(unsigned short port);
extern int swap_disconnect(int sd);
extern int sdp_send(int sd, char *buf, int length);
extern int sdp_receive(int sd, char *buf);
extern int sdp_receive_with_timer(int sd, char *buf, unsigned int expiration);
extern unsigned short checksum(unsigned char buf[], int length);

int session_id = 0;
int R = 0;	// frame number to receive

// Student Section 1: Build ACK frame function
void build_ack(char *ack_frame, int ackNo)
{   
    unsigned char checksum_buf[2];
    
    ack_frame[0] = FLAG;
    ack_frame[1] = ACK;
    ack_frame[2] = ackNo;
    
    checksum_buf[0] = ack_frame[1];
    checksum_buf[1] = ack_frame[2];
    
    unsigned short sum = checksum(checksum_buf, 2);
    
    ack_frame[3] = sum >> 8;
    ack_frame[4] = sum & 0xff;
            
    // Add ending flag
    ack_frame[5] = FLAG;
}

int swap_wait(unsigned short port)
{
	/*
	*	if the session is already open, then return error
	*/

	if (session_id != 0)
		return -1;

	/*
	*	accept a connection
	*/

	session_id = swap_accept(port);	// in sdp.o

	/*
	*	return a ssession id
	*/

	return session_id;
}

// Student Section 2: Swap Read
int swap_read(int sd, char *buf)
{
	int n, data_length, ack_length = 6;
	char ack_frame[MAXFRAME];
	char frame[MAXFRAME];
	unsigned char checksum_buf[MAXFRAME];

        // If session is disconnected or another error, return -1.
	if (session_id == 0 || sd != session_id)
		return -1;
	
        while (1)
        {
	  // receive a DATA frame without a timer
	  n = sdp_receive(sd, frame);
	  
	  printf("Received frame length: %d\n", n);
	  
	  if (n < 0)
	  {
	    return -1;
	  }
	  
	  // Subtract size of flags, checksum, and header from n to get data length
          data_length = n - 6;
	  
          /* Calculate checksum */
          // Copy header + data into checksum buffer
          memcpy(checksum_buf, &frame[1], 2 + data_length);
          
          // Add the checksum length
          int checksum_length = (2 + data_length);
          
          // Check if header + data length is even or odd
          // Must be even for checksum function, so if odd, add temp padding
          if (checksum_length % 2 != 0)
          {
            checksum_buf[checksum_length] = 0; // pad w/ a 0 to make the checksum buffer even
            checksum_length++;
          }
          
          // Call checksum with buffer for checksum and checksum length
          unsigned short sum = checksum(checksum_buf, checksum_length);
          
          int checksum_position = 3 + data_length;
          unsigned short received_sum;
          received_sum = ((unsigned char)frame[checksum_position] << 8) | (unsigned char)frame[checksum_position + 1];
          
          /* Case 1:
          * Verify checksum. 
          * If checksum is bad, frame is corrupted.
          * Discard data.
          * Do not send ACK.
          * Wait for another frame.
          */
          if (sum != received_sum)
          {
            printf("Corrupted frame! Frame discarded.\n");
            continue; // corrupted frame
          }
          
          printf("Checksum OK\n");
          
          // Verify sequence number.
          int seqNo = frame[2];
          printf("Received seqNo %d, expected %d\n", seqNo, R);
          
          /* Case 2:
          * Correct DATA frame w/ seqNo == R
          */
          if (seqNo == R)
          {
            // Copy data to the application buffer
            memcpy(buf, &frame[3], data_length);
            
            // Window slides. Update R 
            R = (R + 1) % 2;
            
            // Build ACK frame (put into separate function to reduce redundancy)
            build_ack(ack_frame, R);
            
            // Send ACK w/ ackNo = R
            //printf("Sending ACK %d\n", R);
            sdp_send(sd, ack_frame, ack_length);
            
            // Return data length.
            return data_length;
          }
          /* Case 3:
          * Correct DATA frame w/ seqNo != R.
          * Duplicate frame.
          * Discard data.
          * Send ACK w/ ackNo = R.
          * Wait for another frame.
          */
          if (seqNo != R)
          {
            // Do NOT copy data to buf
            // Do not update R
            
            // Build ACK frame (put into separate function to reduce redundancy)
            build_ack(ack_frame, R);
            
            // Send ACK w/ ackNo = R.
            sdp_send(sd, ack_frame, ack_length);
          }
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
