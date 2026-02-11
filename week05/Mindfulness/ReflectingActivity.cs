public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() :base("Relection Activity", "This activity will help you reflect on the time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other areas of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time you helped someone in need",
            "Think of a time when you did something truly selfless",
            "Think about what you are trying to accept within yourself at this time",
            "Think of a time when you helped someone in need",
            "Think of a time you did something difficult",
            "Think of a time when you did something that made you happy",
            "Think of a time you really felt the Holy Ghost",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you get started?",
            "What is your favorite thing about this experience?",
            "How did you feel when it was completed?",
            "What did you learn through this experience?",
            "How can you keep this experience in the forefront of your mind?",
            "How can you invite others to experience acceptance and love?",
            "How did you get started?",
            "Have you ever done anything like this before?"
        };
    }
    public override void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(10);
        }

        DisplayEndMessage();


    
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}