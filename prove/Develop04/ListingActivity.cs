


class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10)
    {
        InitializePrompts();
        _count = 0;
    }

    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunListingActivity()
    {
        // string prompt = GetRandomPrompt();
        GetRandomPrompt();
        // Console.WriteLine(prompt);
        Thread.Sleep(5000);
        int duration = GetDuration();

        while (_count < duration)
        {
            Console.Write("Enter an item for the list (or 'exit' to finish): ");
            string item = Console.ReadLine();
            // Console.WriteLine("");
            if (item.ToLower() == "exit")
                break;
            _count++;

        }
        Console.WriteLine($"Number of items entered: {_count}");

    }
    
    private void GetRandomPrompt()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
    }


}