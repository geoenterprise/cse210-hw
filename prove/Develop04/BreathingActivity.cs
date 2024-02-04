


class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.", 0)
    {
          SetDurationFromUserInput();
    }

    private void SetDurationFromUserInput()
    {
        Console.Write("How long in seconds, would you like for your session: ");
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            SetDuration(userInput);
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration.");
        }
    }
    // public int GetDuration()
    // {
    //     return _duration;
    // }
    

    public void RunBreathingActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("");
        Console.WriteLine("Get ready to start...");
        ShowCountDown();
        // Thread.Sleep(3000);
        // SetDuration(20);
        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);  
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            // Thread.Sleep(6000);
            ShowSpinner();
            Console.WriteLine("Breathe out..");
            ShowSpinner();
            Console.WriteLine("");

            
        }

        DisplayEndingMessage();
    }
}