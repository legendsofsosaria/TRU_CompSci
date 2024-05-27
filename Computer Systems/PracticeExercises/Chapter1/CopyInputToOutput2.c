#include <stdio.h>

#define YES 1
#define NO 0 

/* Write a program to copy its input to its output, replacing each tab by \t, each backspace by \b, and each backslash by \\ */
main()
{
    int c, replaced;

    while ((c = getchar()) != EOF) 
    {
		replaced = NO;
		
		if (c == '\t') 
        {
			printf("\\t");
			replaced = YES;
		}
		if (c == '\b') 
        {
			printf("\\b");
			replaced = YES;
		}
		if (c == '\\') 
        {
			printf("\\\\");
			replaced = YES;
		}
		if (replaced == NO)
			putchar(c);
    }
    return 0;
}