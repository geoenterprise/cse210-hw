

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int target, int bonus)
{
    _name = name;
    _description = description;
    _target = target;
    _bonus = bonus;
}
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            IsComplete = true;
        }
    }

    public override int GetPoints()
    {
        return (_amountCompleted * 50) + (IsComplete ? _bonus : 0);
    }

    public override string ToString()
    {
        return $"{_name} - {_description} [Completed {_amountCompleted}/{_target} times] [ {(IsComplete ? "X" : " ")} ]";
    }
}

    
