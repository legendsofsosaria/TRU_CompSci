#include <stdio.h>

int main()
{
    int array[] = {1,2,3,4,5};
    int *p = &array[0];
    printf("*p:%d\n", *p);
    printf("p:%d\n\n", p);
    p++;
    printf("*p:%d\n", *p);
    printf("p:%d\n\n", p);
    (*p)++;
    printf("*p:%d\n", *p);
    printf("p:%d\n\n", p);
    p += 2;
    printf("*p:%d\n", *p);
    printf("p:%d\n\n", p);
    (*p)++;
    printf("*p:%d\n", *p);
    printf("p:%d\n\n", p);

    return 0;
}