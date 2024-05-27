#include <stdio.h>

/* Print all input lines longer than 80 characters */

#define MAX 1000
#define NCHARS 80

/* functions */
int getLine(char [], int);
int trim(char [], int);

/* getLine function: read a line into s, return length */
int getLine(char s[], int lim)
{
	int c, i;

	for (i = 0; i < lim - 1 && (c = getchar()) != EOF && c != '\n'; ++i)
		s[i] = c;

	if (c == '\n') {
		s[i] = c;
		++i;
	}

	s[i] = '\0';

	return i;
}

int rightTrim(char s[], int len)
{
	int nw = 0;

	if (s[--len] == '\n') {
		s[len] = '\0';       /* remove newline character */
		nw = 1;              /* set flag */
	}

	while (--len >= 0  && (s[len] == ' ' || s[len] == '\t'))
		s[len] = '\0';
	++len;

	if (nw)
		s[len] = '\n';       /* add back the newline character */

	return ++len;
}

int main(void)
{
	int  len;                 /* current line length */
	char line[MAX];       /* current input line */

	while ((len = getLine(line, MAX)) > 0) 
	{
		len = trim(line, len);
		
		if (len == 1 && line[0] == '\n') /* delete if line is empty */
			line[0] = '\0';

		printf("%s", line);
	}

	return 0;
}