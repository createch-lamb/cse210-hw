using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompt;

    public ListingActivity() : base("Listing Activity", "This will help you to focus on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompt = new List<string>
        {
            "What are your personal strengths?",
            "Who are the people who encourage you to do your best?",
            "What do you love about yourself?",
            "When have you felt the Holy Ghost this month?",
            "Who are the people that you helped this week?",
        };

        _count = 0;
    }

    public override void Run()
    {
        DisplayStartingMessage();


        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrEmpty(item))
            {
                _count++;
            }
        }
        Console.WriteLine($"You've listed {_count} items");

        DisplayEndMessage();

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}