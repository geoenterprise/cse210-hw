public class AssignmentGrader
{
    private TeacherInterface teacherInterface;
    public AssignmentGrader(TeacherInterface teacherInterface)
    {
        this.teacherInterface = teacherInterface;
    }
    public void GradeAssignmentMenu()
    {
                
        Console.Write("Enter student ID: ");
        int studentID;
        if (!int.TryParse(Console.ReadLine(), out studentID))
        {
            Console.WriteLine("Invalid input. Please enter a valid student ID.");
            return;
        }

        Console.Write("Enter assignment title: ");
        string assignmentTitle = Console.ReadLine();

        Student student = teacherInterface.FindStudentById(studentID);
        Assignment assignment = teacherInterface.FindAssignmentByTitle(assignmentTitle);

        if (student != null && assignment != null)
        {
            Console.Write("Enter score for the assignment: ");
            double score;
            if (!double.TryParse(Console.ReadLine(), out score))
            {
                Console.WriteLine("Invalid input. Please enter a valid score.");
                return;
            }

            // Assign a letter grade based on the provided score
            string letterGrade = GetLetterGrade(score);
            
            // Update the student's final grade and assignment feedback
            student.FinalGrade = score;
            assignment.Feedback = $"Score: {score}. Final Grade: {letterGrade}";

            Console.WriteLine($"Assignment '{assignment.Title}' graded for student {student.LastName}, {student.FirstName}. Score: {score}. Final Grade: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Student or assignment not found.");
        }
    }

    // Method to calculate the letter grade based on the score
    private string GetLetterGrade(double score)
    {
        if (score < 3.0)
        {
            return "Failing";
        }
        else if (score < 3.5)
        {
            return "D";
        }
        else if (score < 4.0)
        {
            return "C";
        }
        else if (score < 4.5)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }
}