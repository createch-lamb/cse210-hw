using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        int guess = -1;

        while ( guess != number )
        {

         Console.WriteLine("Could you guess the magic number?");
         guess = int.Parse(Console.ReadLine());

         if ( number > guess)
         {
            Console.WriteLine("Higher");
         }
         else if (number < guess )
         {
            Console.WriteLine("Lower");
         }
         else 
         {
            Console.WriteLine("You did it! Way to go!");
         }
        } 
    }
}