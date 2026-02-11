public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This will help you relax by walking through breathing in and out slowly. Clear You mind and focus on breathing.")
    {
        
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe In...");
            ShowCountDown(4);

            Console.WriteLine();
            Console.WriteLine("Breathe Out...");
            ShowCountDown(6);
        }

        DisplayEndMessage();
    }
}