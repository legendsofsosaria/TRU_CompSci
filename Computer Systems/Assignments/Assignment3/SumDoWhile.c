#include <stdio.h>

int sum_do_while(int start, int end)
{
    int sum = 0, i = start;

    do
    {
        sum += i;
        i++;
    }
    while (i <= end);

    return sum;
}

int main()
{
    printf("Sum: %d\n", sum_do_while(1, 10));

    return 0;
}