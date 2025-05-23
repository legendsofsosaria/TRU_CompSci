#include <stdio.h>

/* Section 1.5.3, example program
Line counting, counts newline character to count # of lines */
int main()
{
    int c, nl;
    nl = 0;

    while ((c = getchar()) != EOF)
        if (c == '\n')
        ++nl;
    printf("%d\n", nl);

    return 0;
}