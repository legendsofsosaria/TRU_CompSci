#include<string.h>
#include<stdlib.h>
#include<stdio.h>

/* Demonstrates using strtok */
int main(void)
{
    char a[]="This line has 5 different words";
    char *p;

    printf(" %s\n", a);
    p=strtok(a, " ");

    while (p !=NULL)
    {
        printf("%s\t", p);
        p = strtok(NULL," ");
    }
}