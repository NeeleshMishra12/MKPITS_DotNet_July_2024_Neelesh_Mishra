using System;  

public class exercise23  
{  
    static void Main(string[] args) 
    {
        int monno;  

        Console.Write("\n\n");  
        Console.Write("Read month number and display number of days for that month:\n");  
        Console.Write("--------------------------------------------------------------");  
        Console.Write("\n\n");

        Console.Write("Input Month No : ");  
        monno = Convert.ToInt32(Console.ReadLine());  

        switch(monno)  
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.Write("Month has 31 days. \n");  
                break;
            case 2:
                Console.Write("The 2nd month is February and has 28 days. \n");  
                Console.Write("In leap years, February has 29 days.\n");  
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.Write("Month has 30 days. \n");  
                break;
            default:
                Console.Write("Invalid Month number.\nPlease try again ....\n");  
                break;
        }
    }
}
