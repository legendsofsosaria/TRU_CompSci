#include <stdio.h>

#define IN_WORD 1
#define OUT_WORD 0
#define MAX_WORD_LENGTH 10 

int main() {
    int c, state, word_length;
    int word_lengths[MAX_WORD_LENGTH];
    
    state = OUT_WORD;
    word_length = 0;
    
    /* Initialize word_lengths array */
    for (int i = 0; i < MAX_WORD_LENGTH; i++) 
    {
        word_lengths[i] = 0;
    }
    
    /* Count word lengths */ 
    while ((c = getchar()) != EOF) {
        if (c == ' ' || c == '\n' || c == '\t') 
        {
            if (state == IN_WORD) 
            {
                if (word_length <= MAX_WORD_LENGTH) 
                {
                    ++word_lengths[word_length - 1];
                }
                word_length = 0;
                state = OUT_WORD;
            }
        } 
        else 
        {
            state = IN_WORD;
            ++word_length;
        }
    }
    
    /* Print histogram */
    printf("Histogram of word lengths:\n");
    for (int i = 0; i < MAX_WORD_LENGTH; i++) 
    {
        if (word_lengths[i] > 0)
            printf(" | ");

        for (int j = 0; j < word_lengths[i]; j++) 
            printf("_ ");

        if (word_lengths[i] > 0)
            printf("\n");
    }

    return 0;
}