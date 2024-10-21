using System;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations math = new MathOperations();
        Console.WriteLine("Int Addition: " + math.Add(2, 3));
        Console.WriteLine("Double Addition: " + math.Add(2.5, 3.5));
    }
}
