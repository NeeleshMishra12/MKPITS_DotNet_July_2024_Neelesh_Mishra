class Account
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();
        account.Deposit(100);
        Console.WriteLine($"Balance: {account.GetBalance()}"); 
    }
}
