public class GradeInput
{
    // Method to input grades for a student
    public void InputGrades(Student student)
    {
        Console.WriteLine($"Input grades for student: {student.LastName} {student.FirstName}");

        // Asking for grade input on Knowledge
        double knowledgeGrade = PromptForGrade("Knowledge");
        
        // Asking for grade input on skills
        double skillsGrade = PromptForGrade("Skills");
        
        // Asking for grade input on personal development
        double personalDevelopmentGrade = PromptForGrade("Personal Development");

        // Update student's grades
        student.UpdateGrades(knowledgeGrade, skillsGrade, personalDevelopmentGrade);
    }

     private double PromptForGrade(string category)
    {
        Console.Write($"Enter grade for {category}: ");
        double grade;
        while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a valid grade between 0 and 100.");
            Console.Write($"Enter grade for {category}: ");
        }
        return grade;
    }
}