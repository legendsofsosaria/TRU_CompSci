#include <stdio.h>

/* Section 1.5.2, example program
Character counting in input; version 2*/
int main()
{
    double nc;

    for (nc = 0; getchar() != EOF; ++nc)
    ; // C requires a for statement have a body. The isolated semi-colon, called a null statement, fulfills that requirement. Added on a separate line for visibility purposes.
    printf("%.0f\n", nc);

    return 0;
}