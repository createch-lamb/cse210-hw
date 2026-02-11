public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you focus on the blessings in your life by focusing on the things you are grateful for. Gratitude has been shown to reduce stress abd increase happiness.")
    {
        _prompts = new List<string>
        {
            "What is something or somewher in nature that help you clear your mind?",
            "What is a memory you're grateful for?",
            "What is a skill or ability you are grateful to have?",
            "What is a comfort you're grateful for?",
            "What is something that made you smile today?",
            "What is something beautiful you noticed recently?",
            "What is something you look forward to and why?",
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Lets focus on gratitude...");
        ShowSpinner(3);

        List<string> availablePrompts = new List<string>(_prompts);
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime &&  availablePrompts.Count > 0)
        {
            Console.Clear();

            string prompt = GetRandomPrompt(availablePrompts);

            Console.WriteLine("Reflect on the following: ");
            Console.WriteLine();
            Console.WriteLine($"> {prompt}");
            Console.WriteLine();
            Console.WriteLine("Take a moment to pause and reflect...");
            ShowSpinner(10);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your response: ");
            string response = Console.ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);

            }

            Console.WriteLine();
            Console.WriteLine("Thank you for sharing.");
            ShowSpinner(3);
        }

        Console.Clear();
        Console.WriteLine(" ---Your Gratitude Reflections ---");
        Console.WriteLine();
        Console.WriteLine($"You reflected on {responses.Count} things you are grateful for: ");
        Console.WriteLine();

        for (int i = 0; i < responses.Count; i++)
        {
            Console.WriteLine($" {i + 1}. {responses[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("Remembering these blessings can help brighten your day!");
        ShowSpinner(3);

        DisplayEndMessage();

    }
    private string GetRandomPrompt(List<string> availablePrompts)
    {
        Random random = new Random();
        int index = random.Next(availablePrompts.Count);
        string prompt = availablePrompts[index];
        availablePrompts.RemoveAt(index);
        return prompt;
    }
}