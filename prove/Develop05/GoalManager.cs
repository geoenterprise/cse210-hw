

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Run()
    {
        bool exit = false;
        while (!exit)
        {
            DisplayMenu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // CreateGoal(string name, string description, GoalType type, int target = 0, int bonus = 0;
                    Console.WriteLine("Enter goal name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter goal description:");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter goal type (Simple, Eternal, or Checklist):");
                    GoalType type = (GoalType)Enum.Parse(typeof(GoalType), Console.ReadLine());
                    int target = 0;
                    int bonus = 0;
                    if (type == GoalType.Checklist)
                    {
                        Console.WriteLine("Enter goal target:");
                        target = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter goal bonus:");
                        bonus = int.Parse(Console.ReadLine());
                    }
                    CreateGoal(name, description, type, target, bonus);
                    break;
                case "2":
                    Console.WriteLine("Enter the name of the goal to record an event:");
                    string goalName = Console.ReadLine();
                    RecordEvent(goalName);
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Goals");
        Console.WriteLine("4. Display Score");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }

    public void CreateGoal(string name, string description, GoalType type, int target = 0, int bonus = 0)
    {
        switch (type)
        {
            case GoalType.Simple:
                _goals.Add(new SimpleGoal(name, description));
                break;
            case GoalType.Eternal:
                _goals.Add(new EternalGoal(name, description));
                break;
            case GoalType.Checklist:
                _goals.Add(new ChecklistGoal(name, description, target, bonus));
                break;
        }
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                _score += goal.GetPoints();
                break;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
}

public enum GoalType
{
    Simple,
    Eternal,
    Checklist
}