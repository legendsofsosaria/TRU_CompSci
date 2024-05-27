#include <stdio.h>

/* count tabs, spaces, and newlines in input*/
main()
{
    int c, nl, blanks, tabs;

    nl = 0;
    tabs = 0;
    blanks = 0;


    while ((c == getchar()) != EOF)
    {
        if (c == '\n')
            ++nl;
        if (c == '\t')
            ++tabs;
        if (c == ' ')
            ++blanks;
    }

    printf("%d blanks, %d tabs, %d newlines\n", blanks, tabs, nl);

    return 0;
}