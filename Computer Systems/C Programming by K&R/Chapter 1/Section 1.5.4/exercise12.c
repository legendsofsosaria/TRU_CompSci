#include <stdio.h>

// Exercise 1-12, write a program that prints its input one word per line.
int main()
{
    int c, last_char = 0;

    while ((c = getchar()) != EOF)
    {
        if (c == '\n' || c == ' ' || c == '\t') // is this a space, line break or tab?
        {
            if (!last_char) //if the last character wasn't a space, tab, or line break, add a line break and set the flag.
            {
                putchar('\n');
                last_char = 1;
            }
             // If the last character was a space, tab, or line break, do nothing.
        }
        else
        {
            putchar(c); // If it is any other character, print that character
            last_char = 0; // Reset the flag 
        }
    }
    return 0;
}