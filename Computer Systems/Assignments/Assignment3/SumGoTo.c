#include <stdio.h>

int sum_go_to(int start, int end)
{
    int sum = 0, i = start;

    loop_start:
        if (i > end)
        {
            return sum;
        }

        sum += i;
        i++;
        
        goto loop_start;
}

int main()
{
    printf("Sum: %d\n", sum_go_to(1, 10));

    return 0;
}