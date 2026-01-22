using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice ="";

        while (choice != "5")
        {
            //Display Menu
            Console.WriteLine("Pleae select on of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
          
          // displays users choice
            choice = Console.ReadLine();

            if (choice == "1")
            {
                //User writes a new entry
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry. _date = dateText;
                newEntry. _promptText = prompt;
                newEntry. _entryText = response;

                journal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                // Entries are displayed
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                //Load from file
                Console.Write("What would you like to name your file?");
                string filename = Console.ReadLine();
                journal.LoadToFile(filename);
            }

            else if (choice == "4")
            {
                //files are saved
                Console.Write("What is the name of your file?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}