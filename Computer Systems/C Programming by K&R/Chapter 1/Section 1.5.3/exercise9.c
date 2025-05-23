#include <stdio.h>

/* Exercise 9 
Write a program that copies its input to output,
replacing each string of one or more blanks with a single blank. */

int main()
{
    int c, last_space = 0;

    while ((c = getchar()) != EOF)
    {
        if (c == ' ') // Check if the current character is a space
        {
            if (!last_space) // If the last character wasn't a space, print this space
            {
                putchar(c);
                last_space = 1;  // Mark that the last character printed was a space
            }
        }
        else
        {
            putchar(c); // Print the non-space character
            last_space = 0; // Reset the space flag
        }
    }
    return 0;
}