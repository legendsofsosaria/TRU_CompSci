#include <stdio.h>
#include <limits.h>

/* Function prototypes for direct computation */
void compute_char_range();
void compute_short_range();
void compute_int_range();
void compute_long_range();

int main() {
    /* Using standard headers */
    printf("Using standard headers:\n");
    printf("CHAR_MIN: %d\n", CHAR_MIN);
    printf("CHAR_MAX: %d\n", CHAR_MAX);
    printf("UCHAR_MAX: %u\n", UCHAR_MAX);

    printf("SHRT_MIN: %d\n", SHRT_MIN);
    printf("SHRT_MAX: %d\n", SHRT_MAX);
    printf("USHRT_MAX: %u\n", USHRT_MAX);

    printf("INT_MIN: %d\n", INT_MIN);
    printf("INT_MAX: %d\n", INT_MAX);
    printf("UINT_MAX: %u\n", UINT_MAX);

    printf("LONG_MIN: %ld\n", LONG_MIN);
    printf("LONG_MAX: %ld\n", LONG_MAX);
    printf("ULONG_MAX: %lu\n", ULONG_MAX);

    /* Direct computation */
    printf("\nUsing direct computation:\n");
    compute_char_range();
    compute_short_range();
    compute_int_range();
    compute_long_range();

    return 0;
}

void compute_char_range() {
    printf("Signed char range: %d to %d\n", -(1 << (sizeof(char) * 8 - 1)), (1 << (sizeof(char) * 8 - 1)) - 1);
    printf("Unsigned char range: 0 to %u\n", (1U << (sizeof(char) * 8)) - 1);
}

void compute_short_range() {
    printf("Signed short range: %d to %d\n", -(1 << (sizeof(short) * 8 - 1)), (1 << (sizeof(short) * 8 - 1)) - 1);
    printf("Unsigned short range: 0 to %u\n", (1U << (sizeof(short) * 8)) - 1);
}

void compute_int_range() {
    printf("Signed int range: %d to %d\n", -(1 << (sizeof(int) * 8 - 1)), (1 << (sizeof(int) * 8 - 1)) - 1);
    printf("Unsigned int range: 0 to %u\n", (1U << (sizeof(int) * 8)) - 1);
}

void compute_long_range() {
    printf("Signed long range: %ld to %ld\n", -(1L << (sizeof(long) * 8 - 1)), (1L << (sizeof(long) * 8 - 1)) - 1);
    printf("Unsigned long range: 0 to %lu\n", (1UL << (sizeof(long) * 8)) - 1);
}