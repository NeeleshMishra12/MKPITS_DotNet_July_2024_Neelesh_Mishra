class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

class Manager : Employee
{
    public int Bonus { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager
        {
            Name = "Bob",
            Salary = 80000,
            Bonus = 5000
        };
        Console.WriteLine($"Manager: {manager.Name}, Salary: {manager.Salary}, Bonus: {manager.Bonus}");
    }
}
