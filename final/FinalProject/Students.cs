public class Student : User
{
    // Student-specific attributes
    public int GradeLevel { get; set; }
    public double GPA { get; set; }
    public double KnowledgeGrade { get; set; }
    public double SkillsGrade { get; set; }
    public double PersonalDevelopmentGrade { get; set; }
    public double FinalGrade {get; set; }
    // Constructor
    public Student(string lastName, string firstName, int id, int gradeLevel, int knowledgeGrade, int skillsGrade, int personalDevelopmentGrade, int finalGrade, double gpa) : base(lastName, firstName, id)
    {
        KnowledgeGrade = knowledgeGrade;
        SkillsGrade = skillsGrade;
        PersonalDevelopmentGrade = personalDevelopmentGrade;
        FinalGrade = finalGrade;
        GradeLevel = gradeLevel;
        GPA = gpa;
    }

    // Method to display student information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {LastName} {FirstName}, ID: {ID}, Grade Level: {GradeLevel}, \nKnowledge Grade: {KnowledgeGrade} \nSkills Grade: {SkillsGrade} \nPersonal Development Grade: {PersonalDevelopmentGrade} \nFinal Grade: {FinalGrade}, GPA: {GPA}");
    }
    public void UpdateGrades(double knowledgeGrade, double skillsGrade, double personalDevelopmentGrade)
    {
        KnowledgeGrade = knowledgeGrade;
        SkillsGrade = skillsGrade;
        PersonalDevelopmentGrade = personalDevelopmentGrade;
    }
}