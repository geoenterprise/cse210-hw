


public class SimpleGoal : Goal
{
    // private bool _isComplete;

     public SimpleGoal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override int GetPoints()
    {
        return IsComplete ? 100 : 0;
    }

    public override string ToString()
    {
        return $"{_name} - {_description} [ {(IsComplete ? "X" : " ")} ]";
    }
}