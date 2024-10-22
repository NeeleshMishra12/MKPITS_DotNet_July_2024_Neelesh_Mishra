class Program
{
    static void Main(string[] args)
    {
        int age = 20;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
            if (age >= 65)
            {
                Console.WriteLine("You are eligible for senior benefits.");
            }
        }
    }
}
