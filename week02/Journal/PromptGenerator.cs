public class PromptGenerator
{
   public List<string> _prompts = new List<string>();

   //combines the prompts and store them in the list.
   public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today? And why?");
        _prompts.Add("What is a small detail you noticed today that brought you joy?");
        _prompts.Add("How would you describe yourself if you didn't care about others expectations.");
        _prompts.Add("What is something you love about yourself");
        _prompts.Add("What is the kindest thing someones done for you recently?");
        _prompts.Add("What's one small action you can take towards your big goal today?");
    }

    //Pull random prompts
   public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count); //This randomly selects from prompt
        return _prompts[index];
    }

}