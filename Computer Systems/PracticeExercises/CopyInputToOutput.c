#include <stdio.h>

#define YES 1
#define NO 0 

/* Write a program to copy its input to its output, replacing each string of one or more blanks by a single blank */
main()
{
    int c;
    int blank;

    blank = NO;

    while ((c = getchar()) != EOF)
    {
        if (c != ' ')
			 blank = NO;
		if (!blank)
			putchar(c);
		if (c == ' ')
			blank = YES;
    }
    
    return 0;
}