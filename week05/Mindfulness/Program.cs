using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity ");
            Console.WriteLine(" 4. Start Gratitude Activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();

                breathing.Run();

            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Run();
            }
            else if ( choice == "5")
            {
                Console.WriteLine("Thank you! Remember to carry calm forward and to look for the good throughout your day. Until next time, good-bye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        
        
        
        
        

        
    }
}