#include <stdio.h>

int sum_for(int start, int end)
{
    int sum = 0;

    for (int i = start; i <= end; i++)
    {
        sum += i;
    }

    return sum;
}

int main()
{
    printf("Sum: %d\n ", sum_for(1, 10));

    return 0;
}