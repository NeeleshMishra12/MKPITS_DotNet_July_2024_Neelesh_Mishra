#include <stdio.h>
int main() {
    int n, even = 0, odd = 0;
    printf("Enter the number of elements: ");
    scanf("%d", &n);
    int arr[n];
    printf("Enter the elements:\n");
    for (int i = 0; i < n; i++) {
        scanf("%d", &arr[i]);
        if (arr[i] % 2 == 0) {
            even++;
        } else {
            odd++;
        }
    }
    printf("Even numbers: %d\nOdd numbers: %d", even, odd);
    return 0;
}