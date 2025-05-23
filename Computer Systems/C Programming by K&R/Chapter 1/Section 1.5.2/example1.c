#include <stdio.h>
/* Section 1.5.2, example program
Character counting in input; version 1*/
int main()
{
    long nc;
    nc = 0;

    while (getchar() != EOF)
        ++nc;
    printf("%ld\n", nc);
    
    return 0;
}