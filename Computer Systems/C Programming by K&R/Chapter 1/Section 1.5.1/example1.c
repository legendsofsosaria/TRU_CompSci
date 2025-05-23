#include <stdio.h>
/* Section 1.5.1, example program
Copy input to output; 1st version */
int main()
{
    /* c must be big enough to hold any value that getchar returns. We can't use char, 
    because it must be big enough to hold EOF in addition to any possible char. Therefore, we use int */
    int c;

    c = getchar();

    while (c != EOF) // While character is not at end-of-file
    {
        putchar(c); // print the character
        c = getchar(); // get the next character
    }

    return 0;
}