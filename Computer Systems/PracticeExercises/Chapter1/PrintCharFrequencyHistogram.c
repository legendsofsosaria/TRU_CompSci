#include <stdio.h>

#define SIZE 128 /* Size of the ASCII character set */

int main() {
    int c, i, j, count;
    int characters[SIZE];
       
    /* Initialize characters array */
    for (int i = 0; i < SIZE; ++i) 
    {
        characters[i] = 0;
    }

    count = 0;
    
    /* Count character frequencies */ 
    while ((c = getchar()) != EOF) 
    {
        if (c >= ' ' && c <= '~') 
        { 
            ++characters[c]; 
            ++count; 
        }
    }

    if (!count)
        return -1;
    
    /* Print histogram */
    printf("Histogram of character frequency!\n\n");

    for (int i = ' '; i <= '~'; ++i) 
    { 
        if (characters[i] != 0) 
        { 
            printf(" %c", i); 

            for (j = 1; j <= characters[i]; ++j) 
                printf(" _");

            printf("\n");
        }
    }

    return 0;
}