using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "John";
        person.Age = 30;
        person.Greet();
    }
}
