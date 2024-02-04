


class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void StartActivity()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000);
        RunActivity();
        DisplayEndingMessage();
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Get ready for {_name} activity!");
        Console.WriteLine(_description);
    }
    public void RunActivity()
    {
        //I need this as an empty method since each activity will have it's own performactivity

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_name} activity.");
        Console.WriteLine($"Time spent: {_duration} seconds");
        Thread.Sleep(3000);
    }
        
    
    public void SetDuration(int duration)
    {
        _duration = duration;
        
    }

    protected int GetDuration()
    {
        return _duration;
    }
    public void ShowSpinner ()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(800);
        //     Console.Write("\b \b");

        // }

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(10);

        // // while (DateTime.Now < endTime)
        // // {
        // //     Console.Write(ShowSpinner());
        // // }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i =0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        for (int c = 5; c > 0; c--)
        {
            Console.Write(c);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("Done");
        // int i =0;

        // while (DateTime.Now < endTime)
        // {
        //     Console.WriteLine(i);
        //     Console.Write(s);
        //     Thread.Sleep(800);
        //     Console.Write("\b \b");
        //     i++;

        //     if (i >= animationStrings.Count)
        //     {
        //         i = 0;
        //     }
        // }

    }
    
    

}