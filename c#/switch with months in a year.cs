using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter a month number (1-12): ");
        int month = int.Parse(Console.ReadLine());

        switch (month) {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("First quarter of the year.");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Second quarter of the year.");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Third quarter of the year.");
                break;
            case 10:
            case 11:
            case 12:
                Console.WriteLine("Fourth quarter of the year.");
                break;
            default:
                Console.WriteLine("Invalid month number.");
                break;
        }
    }
}
