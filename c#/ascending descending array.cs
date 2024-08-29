using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       
            int[] array = { 1, 2, 3, 4, 5, };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Array.Sort(array);
            Console.WriteLine(" sorted array");

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(array);
            Console.WriteLine("sorted array in descending order");

            foreach(int i in array)
              { Console.WriteLine(i); }

            Console.Read();

    }
}