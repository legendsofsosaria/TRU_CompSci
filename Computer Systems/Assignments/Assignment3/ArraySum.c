/* 
Elizabeth House
Programming Assignment #3
08/22/2024
T00738901
References: https://www.geeksforgeeks.org/how-to-measure-time-taken-by-a-program-in-c/
*/

#include <stdio.h>
#include <time.h>

/* Define the array as size of 50
Number of iterations to run as 500k */
#define SIZE 50
#define ITERATIONS 500000

int main()
{
    int arr[SIZE];
    int sum = 0;
    clock_t start, end;
    double cpu_time;

    start = clock();
    
    /* Initialize the array with 1-50 */
    for (int i = 0; i < SIZE; i++)
    {
        arr[i] = i + 1;
    }

     /* Added a large amount of iterations because testing 
    running this once does not show performance differences */
    for (int i = 0; i < ITERATIONS; i++)
    {
        /* Sum the array elements */
        for (int i = 0; i < SIZE; i++)
        {
            sum += arr[i];
        }
    }

    /* Print the sum */
    printf("The sum of the array elements is %d\n", sum);

    end = clock();
    cpu_time = ((double) (end - start)) / CLOCKS_PER_SEC;

    /* Print the clock time of the function */
    printf("The sum function took %f seconds to execute\n", cpu_time);

    return 0;
}