#include <string.h>
#include<stdio.h>

/* Demonstrates using strcat and strncat */
int main(void)
{
    char s1[20]="Happy ";
    char s2[]="New Year";
    char s3[40];

    printf("%s %s\n", s1, s2);
    printf("strcat(s1,s2) = %s\n", strcat(s1, s2));
    printf("strncat (s3, s1, 6) = %s\n", strncat(s3,s1,6));

    return 0;
}