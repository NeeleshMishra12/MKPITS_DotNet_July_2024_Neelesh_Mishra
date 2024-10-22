class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30 };
        numbers[1] = 50; // Change the second element
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
         
    }
}
