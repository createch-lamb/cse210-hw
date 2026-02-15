using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        Console.WriteLine("Welcome to Eternal Quest!");

        while (running)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("           Main Menu          ");
            Console.WriteLine("==============================");
            Console.WriteLine(" 1. Display Score");
            Console.WriteLine(" 2. Display Goals");
            Console.WriteLine(" 3. Create New Goal");
            Console.WriteLine(" 4. Record Event");
            Console.WriteLine(" 5. Save Goals");
            Console.WriteLine(" 6. Load Goals");
            Console.WriteLine(" 7. Quit");
            Console.WriteLine("==============================");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
               manager.DisplayScore();
            else if (choice == "2")
                manager.DisplayGoals();
            else if (choice == "3")
                manager.CreateGoal();
            else if (choice == "4")
                manager.RecordEvent();
            else if (choice == "5")
                manager.SaveGoals();
            else if (choice == "6")
                manager.LoadGoals();
            else if (choice == "7")
            {
                Console.WriteLine("Try your best to stay focused on your goal. Until next time, Good-bye.");
                running = false;
            }
            else
               Console.WriteLine("Invalid Option, please try again.");
        }
    }
}