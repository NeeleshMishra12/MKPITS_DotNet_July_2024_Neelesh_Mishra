using System;

interface IVehicle
{
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle myCar = new Car();
        myCar.Start();
        myCar.Stop();
    }
}
