#include <stdio.h>
/* Section 1.5.1, example program
Copy input to output; 2nd version */
int main()
{
    /* c must be big enough to hold any value that getchar returns. We can't use char, 
    because it must be big enough to hold EOF in addition to any possible char. Therefore, we use int */
    int c;

    while ((c = getchar()) !=EOF)
        putchar(c);

    return 0;
}