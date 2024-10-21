using System;

class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
            balance -= amount;
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        account.Withdraw(200);
        account.DisplayBalance();
    }
}
