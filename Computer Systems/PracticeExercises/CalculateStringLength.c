#include <stdio.h>

/* Gets a string and prints the length of string, excluding the \0 character */
int main()
{ 
    char s[1000],i;

    printf("Enter a string: ");
    scanf("%s",s);

    for(i=0; s[i]!='\0'; ++i);
    printf("Length of string: %d",i);

    return 0;
}