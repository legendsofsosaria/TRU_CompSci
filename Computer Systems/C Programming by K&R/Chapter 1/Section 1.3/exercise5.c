#include <stdio.h>

/* Exercise 1-5
Print Fahrenheit-Celsius table in reverse from 300F down to 0F */
int main()
{
    int fahr;

    printf(" ---------------------------------\n");
    printf("| Temperature Conversion | F to C |\n");
    printf(" ---------------------------------\n");

    for (fahr = 300; fahr >= 0; fahr = fahr - 20)
        printf("%3d %6.1f\n", fahr, (5.0 / 9.0) * (fahr - 32));

    return 0;
}