using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John" , 3, 16);

        string text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Please press Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All the words are hidden. Great job on memorizing your scriptures!");
    }
}