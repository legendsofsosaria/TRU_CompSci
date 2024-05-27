#include <stdio.h>

#define LOWER 0 /* lower limit of table */
#define UPPER 300 /* upper limit of table */
#define STEP 20 /* step size */

/* Print Fahrenheit-Celsius table from 0 to 300 */
main()
{
    int fahr;

    printf("Fahrenheit to Celsius:\n");
    printf("-----------------------\n");

    for (fahr = LOWER; fahr <= UPPER; fahr = fahr + STEP)
        printf("%3d %6.1f\n", fahr, (5.0 / 9.0) * (fahr - 32));

    return 0;
}