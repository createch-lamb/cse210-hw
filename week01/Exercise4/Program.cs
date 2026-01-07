using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers = new List<int>();

        int userNum = -1;



        while (userNum != 0)
        {
            Console.Write("Enter a random number (Select 0 to quit)");

            string userRes = Console.ReadLine();
            userNum = int.Parse(userRes);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }

       
        int sum = 0;
        foreach (int number in numbers)
            {
                sum += number;
            }
        Console.WriteLine($"The total is {sum}");

        int average = ((int) sum) / numbers.Count;
        Console.WriteLine($"Average is: {average}");

        int max = 0;
        foreach ( int number in numbers )
            {
                if (number > max)
                {
                    max = number;
                }

        Console.WriteLine($"The largest number is: {max} ");
            }
            {
                
            }
        {
            
        }
        }
    }
}