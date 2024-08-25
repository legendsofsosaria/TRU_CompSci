#include <stdio.h>

int sum_while(int start, int end)
{
    int sum = 0, i = start;

    while (i <= end)
    {
        sum += i;
        i++;
    }

    return sum;
}

int main()
{
    printf("Sum: %d\n", sum_while(1, 10));

    return 0;
}