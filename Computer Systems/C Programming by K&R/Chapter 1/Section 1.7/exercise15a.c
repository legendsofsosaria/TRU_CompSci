#include <stdio.h>

#define LOWER 0 /* lower limit of table */
#define UPPER 300 /* upper limit of table */
#define STEP 20 /* step size */

float conversion(float celsius);

/* Print Celsius-Fahrenheit table for fah = 0, 20, ...., 300 */
int main()
{
    int celsius;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | C to F |\n");
    printf(" ---------------------------------\n");

    conversion(celsius);

    for (celsius = LOWER; celsius <= UPPER; celsius = celsius + STEP)
        printf("%3d %6.0f\n", celsius, conversion(celsius));

    return 0;
}

float conversion(float celsius)
{
    float fahrenheit;

    fahrenheit = (9.0 / 5.0) * celsius + 32.0;

    return fahrenheit;
}