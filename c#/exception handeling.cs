using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
