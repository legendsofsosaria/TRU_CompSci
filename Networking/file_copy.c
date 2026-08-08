#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <unistd.h>
#define BUFFER_SIZE 1024
/* argv[1]: from */
/* argv[2]: to */

int main(int argc, char* argv[])
{
	if (argc < 3) {
		printf("Usage: %s <source> <destination>\n", argv[0]);
		exit(1);
	}

	int in, out;
	ssize_t bytesRead, bytesWritten;
	char buffer[BUFFER_SIZE];

	// Open source file
	in = open(argv[1], O_RDONLY);
	if (in < 0) {
		printf("Cannot open the file %s\n", argv[1]);
		exit(1);
	}

	// Open destination file
	out = open(argv[2], O_WRONLY | O_TRUNC | O_CREAT, S_IRUSR | S_IWUSR);
	if (out < 0) {
		printf("Cannot create the file %s\n", argv[2]);
		close(in);
		exit(1);
	}

	// Copy loop
	while ((bytesRead = read(in, buffer, BUFFER_SIZE)) > 0) {
		// Print to the screen
		write(STDOUT_FILENO, buffer, bytesRead);
		
		// Write to destination file
		bytesWritten = write(out, buffer, bytesRead);
		if (bytesWritten != bytesRead) {
			printf("Write error\n");
			close(in);
			close(out);
			exit(1);
		}
	}
	
	if (bytesRead < 0) {
		printf("Read error\n");
	}

	close(in);
	close(out);

	// Compare files
	int in2 = open(argv[1], O_RDONLY);
	int out2 = open(argv[2], O_RDONLY);

	char buf1[BUFFER_SIZE], buf2[BUFFER_SIZE];
	ssize_t r1, r2;
	int identical = 1;

	while(1) {
		r1 = read(in2, buf1, BUFFER_SIZE);
		r2 = read(out2, buf2, BUFFER_SIZE);
	
		if (r1 != r2) {
			identical = 0;
			break;
		}
		
		if (r1 == 0) { // EOF
			break;
		}

		for (int i = 0; i < r1; i++) {
			if (buf1[i] != buf2[i]) {
				identical = 0;
				break;
			}
		}

		if (!identical) break;
	}
	
	close(in2);
	close(out2);

	if (identical) { 
		printf("\nFiles are identical\n");
	}
	else {
		printf("\nFiles are NOT identical\n");
	}

	return 0;
}
