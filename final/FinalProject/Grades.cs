public class Grades
{
    // Properties for grades in different categories
    public double KnowledgeGrade { get; set; }
    public double SkillsGrade { get; set; }
    public double PersonalDevelopmentGrade { get; set; }

    // Constructor
    public Grades(double knowledgeGrade, double skillsGrade, double personalDevelopmentGrade)
    {
        KnowledgeGrade = knowledgeGrade;
        SkillsGrade = skillsGrade;
        PersonalDevelopmentGrade = personalDevelopmentGrade;
    }

    // Method to display grades
    public void DisplayGrades()
    {
        Console.WriteLine("Grades:");
        Console.WriteLine($"Knowledge: {KnowledgeGrade}");
        Console.WriteLine($"Skills: {SkillsGrade}");
        Console.WriteLine($"Personal Development: {PersonalDevelopmentGrade}");
    }
}