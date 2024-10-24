using System;

class Program {
    static void Main() {
        int num, reverse = 0, remainder;
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        do {
            remainder = num % 10;
            reverse = reverse * 10 + remainder;
            num /= 10;
        } while (num > 0);

        Console.WriteLine("Reversed number: " + reverse);
    }
}
