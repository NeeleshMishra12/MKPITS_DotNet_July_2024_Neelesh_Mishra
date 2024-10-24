using System;

class Program {
    static void Main() {
        int correctNumber = 7, guess;
        do {
            Console.WriteLine("Guess the number (between 1 and 10): ");
            guess = Convert.ToInt32(Console.ReadLine());
        } while (guess != correctNumber);

        Console.WriteLine("Correct! You guessed the number.");
    }
}
