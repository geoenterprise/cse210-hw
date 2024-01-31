

class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    public MathAssignment(string name, string topic, string textBookSection, string problem) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} - Problems: {_problem}";
    }
}