

class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflecton", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 2)
    {
        InitializePrompts();
        InitializeQuestions();
    }

    //changed this from DisplayPrompt to have the print statement inside my Run  method.
    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    //changed this from Displayquestions to have the print statement inside my Run method.
    private void InitializeQuestions()
    {
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?"
        };

    }

    public void RunReflectionActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        foreach (var question in GetRandomQuestions())
        {
            Console.WriteLine(question);
            Thread.Sleep(3000);
        }
    }

    private string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
    private string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    }

    private IEnumerable<string> GetRandomQuestions()
    {
        int duration = GetDuration();
        for (int i = 0; i < duration; i++)
        {
            yield return GetRandomQuestion();
            Thread.Sleep(3000);

        }

    }


}