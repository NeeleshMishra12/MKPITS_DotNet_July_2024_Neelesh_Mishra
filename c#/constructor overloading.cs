using System;

class Person
{
    public string name;
    public int age;

    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();
        Person person2 = new Person("John", 30);

        person1.DisplayInfo();
        person2.DisplayInfo();
    }
}
