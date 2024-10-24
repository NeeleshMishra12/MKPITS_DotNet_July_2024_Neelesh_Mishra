
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}


class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal1 = new Dog();
        Animal myAnimal2 = new Cat();
        myAnimal1.Speak(); // Outputs: Bark
        myAnimal2.Speak(); // Outputs: Meow
    }
}
