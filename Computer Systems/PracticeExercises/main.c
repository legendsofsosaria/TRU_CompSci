#include <stdio.h>
#include <stddef.h> // For offsetof macro

struct foo {
    char *a;
    short b;
    double c;
    char d;
    float e;
    char f;
    long long g;
    void *h;
};

int main() {
    printf("Offset of a: %zu bytes\n", offsetof(struct foo, a));
    printf("Offset of b: %zu bytes\n", offsetof(struct foo, b));
    printf("Offset of c: %zu bytes\n", offsetof(struct foo, c));
    printf("Offset of d: %zu bytes\n", offsetof(struct foo, d));
    printf("Offset of e: %zu bytes\n", offsetof(struct foo, e));
    printf("Offset of f: %zu bytes\n", offsetof(struct foo, f));
    printf("Offset of g: %zu bytes\n", offsetof(struct foo, g));
    printf("Offset of h: %zu bytes\n", offsetof(struct foo, h));

    printf("Total size of struct foo: %zu bytes\n", sizeof(struct foo));

    return 0;
}