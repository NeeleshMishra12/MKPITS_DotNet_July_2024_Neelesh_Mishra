class Program
{
    static void Main(string[] args)
    {
        int age = 25;
        bool hasLicense = true;

        if (age >= 18 && hasLicense)
        {
            Console.WriteLine("You can legally drive.");
        }
        else
        {
            Console.WriteLine("You cannot drive.");
        }
    }
}
s