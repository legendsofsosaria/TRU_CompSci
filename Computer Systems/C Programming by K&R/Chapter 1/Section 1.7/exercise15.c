#include <stdio.h>

#define LOWER 0 // lower limit of table 
#define UPPER 300 // upper limit of table 
#define STEP 20 // step size 

float conversion(float fahr);

 // Print fahrenheit-celsius table for fahr = 0, 20, ...., 300
int main()
{
    int fahr;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | F to C |\n");
    printf(" ---------------------------------\n");

    conversion(fahr);

    for (fahr = LOWER; fahr <= UPPER; fahr = fahr + STEP)
        printf("%3d %6.1f\n", fahr, conversion(fahr));

    return 0;
}

float conversion(float fahr)
{
    float celsius;

    celsius = (5.0 / 9.0) * (fahr - 32.0);

    return celsius;
}