#include <stdio.h>

 /* Exercise 1-4
Print celsius-fahrenheit table for -40C to 260C */
int main()
{
    float fahr, celsius;
    int lower, upper, step;

    lower = -40; // Lower limit of temperature table
    upper = 260; // Upper limit of temperature table
    step = 20; // Step size
    celsius = lower;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | C to F |\n");
    printf(" ---------------------------------\n");

    while (celsius <= upper)
    {
        fahr =( (9.0 / 5.0) * celsius + 32.0);
        printf("%3.0f %3.0f\n", celsius, fahr);
        celsius = celsius + step;
    }

    return 0;
}