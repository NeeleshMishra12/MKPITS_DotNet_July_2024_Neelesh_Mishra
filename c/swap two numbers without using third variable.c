#include <stdio.h>

int main()
 {
    int a = 5, b = 10;
    printf("Before swapping: a = %d, b = %d\n", a, b);

    // Add the values of a and b
    a = a + b;
  
    // Subtract the value of b from a
  
    b = a - b;
  
    // Subtract the new value of b from a
    a = a - b;

    printf("After swapping: a = %d, b = %d\n", a, b);
    return 0;
}