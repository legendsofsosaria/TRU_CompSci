#include <stdio.h>

/* Section 1.6, exercise 14
Write a program to print a histogram of the frequencies of different characters in its input */ 


#define ALPHABET 26
#define NUMBER 10

int main(void)
{
  char c, char_freq[ALPHABET + NUMBER];

  // Initialize the char_freq array with 0
  for (int i = 0; i < (ALPHABET + NUMBER); ++i)
  {
    char_freq[i] = 0;
  }

  // Count characters from the standard input
  while ((c = getchar()) != EOF)
  {
    if (c >= 'a' && c <= 'z')
    {
      ++char_freq[c - 'a'];
    }
    else if (c >= '0' && c <= '9')
    {
      ++char_freq[c - '0' + ALPHABET];
    }
  }

  // Print horizontal histogram
  for (int i = 0; i < (ALPHABET + NUMBER); ++i)
  {
    if (i < ALPHABET)
    {
      printf("%c: ", 'a' + i);
    }
    else if (i >= ALPHABET)
    {
      printf("%c: ", '0' + i - ALPHABET);
    }

    for (int j = 0; j < char_freq[i]; ++j)
    {
      printf("=");
    }

    putchar('\n');
  }

  return 0;
}