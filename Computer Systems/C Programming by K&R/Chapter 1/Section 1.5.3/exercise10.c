#include <stdio.h>

/* Exercise 10
Write a program to copy its input to its output, replacing each tab
with \t, each backspace by \b, and each backslash by \\. 
This makes tabs and backspaces visible in an unambiguous way. */
int main()
{
    int c;

    while ((c = getchar()) != EOF)
    {
        if (c == '\t') // Check if the current character is a tab
        {
           putchar('\\');
           putchar('t'); // Print explicit \t for tab
        }
        else if (c == '\b') // Check if the current character is a backspace
        {
            putchar('\\');
            putchar('b'); // Print explicit \b for backspace 
        }
        else if (c == '\\') // Check if the current character is a backslash
        {
            putchar('\\');
            putchar('\\'); // Print explicit backslash
        }
        else
        {
            putchar(c); // Print all other characters normally
        }
    }
    return 0;
}