#include <stdio.h>
#define MAXLINE 1000 /* maximum input line size */

int getline(char[], int);
void copy(char[], char[]);

/* getline: read a line into s, return length */
 int getline(char s[], int lim)
 {
    int c, i;

    for (i = 0; i < lim - 1 && (c = getchar()) != EOF && c != '\n'; ++i)
        s[i] = c;

    if (c == '\n')
    {
        s[i] = c;
        ++i;
    }

    s[i] = '\0';

    return i;
 }

 /* copy: copy 'from' into 'to'; assume to is big enough */
 void copy(char to[], char from[])
 {
    int i;

    i = 0;

    while ((to[i] = from[i]) != '\0')
        ++i;
 }

/* print longest input line */
int main()
{
    int len;                    /* current line length */
    int nextLen;                /* next line length */
    int max;                    /* maximum length seen so far */
    char line[MAXLINE];         /* current input line */
    char nextLine[MAXLINE];     /* next input line */
    char longest[MAXLINE];      /* longest line saved here */

    max = 0;

    while ((len = getline(line, MAXLINE)) > 0)
    {
        if (len == MAXLINE - 1)
        {
            line[MAXLINE - 1] = '\n';
            nextLen = len;

            while (nextLen == MAXLINE - 1)
            {
                nextLen = getline(nextLine, MAXLINE);
                len += nextLen;
            }
        }
        if (len > max) 
        {
            max = len;
            copy(longest, line);
        }
    }
    
    if (max > 0) 
        printf("%s -> %i\n", longest, max);
    
    return 0;
 }