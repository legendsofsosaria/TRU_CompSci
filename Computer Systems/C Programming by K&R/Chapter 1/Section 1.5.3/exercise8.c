#include <stdio.h>

int main()
{
    int c, space = 0, tab = 0, nl = 0;

    while ((c = getchar()) != EOF)
    {
        if (c == '\n')
        ++nl;
        else if (c == '\t')
        ++tab;
        else if (c == ' ')
        ++space;
    }

    printf("Spaces: %d, New Lines: %d, Tabs: %d", space, nl, tab);
    return 0;
}