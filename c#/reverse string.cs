using System;

public class HelloWorld
{ 
    public static void Main(string[] args)
    {
        string str= "boby";
       // Console.WriteLine("enter string value");
        //str=Console.ReadLine();
        
         Console.WriteLine("string entered character wise is ");
         for(int i=0;i<str.Length;i++)
         {
             Console.WriteLine(str[i]);
         }
         
         Console.WriteLine("string entered reverse order is ");
         for(int i=str.Length-1;i>=0;i--)
         {
             Console.WriteLine(str[i]);
         }
         
         Console.Read();
         
    }
}