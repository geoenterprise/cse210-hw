

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public override void RecordEvent()
    {
        // Eternal goals are always considered complete
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