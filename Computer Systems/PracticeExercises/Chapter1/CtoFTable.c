#include <stdio.h>

#define LOWER 0 /* lower limit of table */
#define UPPER 300 /* upper limit of table */
#define STEP 20 /* step size */

/* Print Celsius-Fahrenheit table for fah = 0, 20, ...., 300 */
main()
{
    int celsius;

    printf("Celsius to Fahrenheit:\n");
    printf("-----------------------\n");

    for (celsius = LOWER; celsius <= UPPER; celsius = celsius + STEP)
        printf("%3d %6.0f\n", celsius, (9.0 / 5.0) * celsius + 32.0);

    return 0;
}