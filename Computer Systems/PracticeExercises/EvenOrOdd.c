#include <stdio.h>

/* Function to check if a number is even or odd using bitwise operators */
void isEvenOrOdd(int number) 
{
    if (number & 1) 
    {
        /* If the least significant bit is 1, the number is odd */
        printf("%d is an odd number.\n", number);
    } 
    else 
    {
        /* If the least significant bit is 0, the number is even */
        printf("%d is an even number.\n", number);
    }
}

int main() 
{
    int number;

    /* Input number from user */
    printf("Enter an integer: ");
    scanf("%d", &number);

    /* Check if the number is even or odd */
    isEvenOrOdd(number);

    return 0;
}