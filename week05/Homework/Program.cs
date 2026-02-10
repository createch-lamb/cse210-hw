using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Afia Robinson", "Wonders Of The World");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Veronica Calls", "Mixed Fractions", "10.5", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Zoe Delani", "Essay Writing", "Become A Pro at Writing Essays");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}