using System;

class Program
{
    static void Main(string[] args)
    {
       GoalManager goalManager = new GoalManager();

        goalManager.CreateGoal("Read Scriptures", "Read scriptures daily", GoalType.Eternal);
        goalManager.CreateGoal("Run Marathon", "Run a marathon", GoalType.Simple);
        goalManager.CreateGoal("Attend Temple", "Attend temple 10 times", GoalType.Checklist, 10, 500);

        goalManager.DisplayGoals();

        goalManager.RecordEvent("Read Scriptures");
        goalManager.RecordEvent("Attend Temple");
        goalManager.RecordEvent("Attend Temple");
        goalManager.RecordEvent("Run Marathon");

        goalManager.DisplayGoals();
        goalManager.DisplayScore();
    }
}