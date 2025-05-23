#include <stdio.h>
#define LOWER 0 // Lower limit of table
#define UPPER 300 // Upper limit of table
#define STEP 20 // Step size

/* Section 1.4 example program 
Print Fahrenheit-Celsius table in reverse from 0F to 300F */
int main()
{
    int fahr;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | F to C |\n");
    printf(" ---------------------------------\n");

    for (fahr = LOWER; fahr <= UPPER; fahr = fahr + STEP)
        printf("%3d %6.1f\n", fahr, (5.0 / 9.0) * (fahr - 32));

    return 0;
}