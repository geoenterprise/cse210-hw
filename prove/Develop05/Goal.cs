


public abstract class Goal
{
    // private string _shortName;
    // private string _description;
    // private string _points;

    // public Goal(string name, string description, string points)
    // {
    //     _shortName = name;
    //     _description = description;
    //     _points = points;
    // }
    protected string _name;
    protected string _description;

    public string Name { get { return _name; } }
    public bool IsComplete { get; protected set; }

    public override string ToString()
    {
        return $"{_name} - {_description} [ {(IsComplete ? "X" : " ")} ]";
    }

    public abstract void RecordEvent();
    public abstract int GetPoints();

}