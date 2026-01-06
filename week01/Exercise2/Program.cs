using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade average?");
        string usersGradeAverage = Console.ReadLine();
        int x = int.Parse(usersGradeAverage);
        
        string letter = "";

        if  ( x >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations!");
        }
        else if ( x >= 80 )
        {
            letter = "B";
            Console.WriteLine("Congratulations!");
        }

        else if ( x >= 70)
        {
            letter = "C";
            Console.WriteLine("Congratulations");


        }
        else if ( x >= 60)
        {
            letter = "D";
            Console.WriteLine("Maybe Next Time");

        }
        else
        {
            letter = "F";
            Console.WriteLine("Maybe Next Time");
        }
    }
}