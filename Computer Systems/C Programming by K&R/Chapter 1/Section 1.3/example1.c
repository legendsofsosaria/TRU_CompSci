#include <stdio.h>

// Print Fahrenheit-Celsius conversion table, from 0F to 300F
int main()
{
    int fahr;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | F to C |\n");
    printf(" ---------------------------------\n");

    for (fahr = 0; fahr <= 300; fahr = fahr + 20)
        printf("%3d %6.1f\n", fahr, (5.0 / 9.0) * (fahr - 32));

    return 0;
}