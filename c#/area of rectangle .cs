using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        Console.WriteLine("Enter the Length of a Rectangle: ");
        int Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Breadth of a Rectangle: ");
        int Breadth = Convert.ToInt32(Console.ReadLine());

        int Area = Length * Breadth;
        Console.WriteLine("Area of Rectangle is " + Area);
        Console.ReadKey();
    }
}