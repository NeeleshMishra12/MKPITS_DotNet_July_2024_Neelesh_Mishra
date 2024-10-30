#include <stdio.h>
int main() {
    float salary, netSalary;
    printf("Enter the gross salary: ");
    scanf("%f", &salary);
    if (salary <= 25000) {
        netSalary = salary * 0.9;  // 10% tax
    } else if (salary <= 50000) {
        netSalary = salary * 0.8;  // 20% tax
    } else {
        netSalary = salary * 0.7;  // 30% tax
    }
    printf("Net salary after tax: $%.2f", netSalary);
    return 0;
}
