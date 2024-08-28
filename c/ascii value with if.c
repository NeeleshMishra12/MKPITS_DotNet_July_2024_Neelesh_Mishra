// Online C compiler to run C program online
#include <stdio.h>

int main() 
{
    char c;
    int d;
    
    printf("Enter the character : ");
    scanf("%c",&c);
    printf("Ascii value of  %c=%d",c,c );
    
    printf("\nEnter the number : ");
    scanf("%d",&d);
    printf("Ascii value of %d=%c",d,d);
    
   if(c==d)
    {
        printf("\nBoth the enter value are same");
    }
    else
    {
        printf("\nBoth the enter value are different");
    }
    

    return 0;
}