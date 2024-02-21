using System;

public class TeacherInterface
{
    private AssignmentRepository assignmentRepository;
    private AssignmentGrader assignmentGrader;
    private FileManager fileManager;
    
    private string studentsFilePath = "PlantaEstudiantil2.csv";
    public TeacherInterface()
    {
        assignmentRepository = new AssignmentRepository();
        assignmentGrader = new AssignmentGrader(this);
        fileManager = new FileManager();
        
    }

    // Method to display the menu and handle user input
    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Teacher Menu:");
            Console.WriteLine("1. Show Grade Level Students List");
            Console.WriteLine("2. Show Student Information");
            Console.WriteLine("3. Create Assignment");
            Console.WriteLine("4. Grade Assignment");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowGradeLevelStudentsList();
                    break;
                case "2":
                    ShowStudentInformation();
                    break;
                case "3":
                    CreateAssignmentMenu();
                    break;
                case "4":
                    GradeAssignmentMenu();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
    private void CreateAssignmentMenu()
    {
        Console.Write("Enter assignment title: ");
        string title = Console.ReadLine();

        Console.Write("Enter assignment description: ");
        string description = Console.ReadLine();

        Console.Write("Enter assignment category: ");
        string category = Console.ReadLine();

        Console.Write("Enter due date (yyyy-MM-dd): ");
        DateTime dueDate;
        if (!DateTime.TryParse(Console.ReadLine(), out dueDate))
        {
            Console.WriteLine("Invalid input. Please enter a valid due date in the format yyyy-MM-dd.");
            return;
        }

        Console.Write("Enter maximum score: ");
        int maxScore;
        if (!int.TryParse(Console.ReadLine(), out maxScore))
        {
            Console.WriteLine("Invalid input. Please enter a valid maximum score.");
            return;
        }

        CreateAssignment(title, description, category, dueDate, maxScore);
    }
    public Student FindStudentById(int studentID)
    {
        
        List<Student> students = fileManager.ReadStudentsFromCSV(studentsFilePath);

        return students.FirstOrDefault(s => s.ID == studentID);
    }

    // Method to find an assignment by title
    public Assignment FindAssignmentByTitle(string assignmentTitle)
    {
        List<Assignment> assignments = assignmentRepository.GetAllAssignments();

        return assignments.FirstOrDefault(a => a.Title == assignmentTitle);
    }
    private void GradeAssignmentMenu()
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

        Student student = FindStudentById(studentID);
        Assignment assignment = FindAssignmentByTitle(assignmentTitle);

        if (student != null && assignment != null)
        {
            Console.Write("Enter score for the assignment: ");
            double score;
            if (!double.TryParse(Console.ReadLine(), out score))
            {
                Console.WriteLine("Invalid input. Please enter a valid score.");
                return;
            }

            Console.Write("Enter feedback for the assignment: ");
            string feedback = Console.ReadLine();
            
            GradeAssignment(student, assignment, score, feedback);
        }
        else
        {
            Console.WriteLine("Student or assignment not found.");
        }
    }
    // Method to display a list of grade-level students
    private void ShowGradeLevelStudentsList()
    {
        Console.Write("Enter the grade level: ");
        if (!int.TryParse(Console.ReadLine(), out int gradeLevel))
        {
            Console.WriteLine("Invalid input. Please enter a valid grade level.");
            return;
        }

        List<Student> students = fileManager.ReadStudentsFromCSV("PlantaEstudiantil2.csv");

        if (students != null && students.Any())
        {
            // Filter students by grade level
            List<Student> filteredStudents = students.Where(s => s.GradeLevel == gradeLevel).ToList();

            if (filteredStudents.Any())
            {
                Console.WriteLine($"Grade {gradeLevel} Students List:");
                foreach (Student student in filteredStudents)
                {
                    student.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine($"No students found in grade {gradeLevel}.");
            }
        }
        else
        {
            Console.WriteLine("No students found.");
        }
    }
    // Method to display information about a specific student
    private void ShowStudentInformation()
    {
        Console.Write("Enter student ID: ");
        int studentID = int.Parse(Console.ReadLine());
        
        List<Student> students = fileManager.ReadStudentsFromCSV(studentsFilePath);

        Student student = students.FirstOrDefault(s => s.ID == studentID);

        if (student != null)
        {
            Console.WriteLine("Student Information:");
            student.DisplayInfo();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
    public void CreateAssignment(string title, string description, string category, DateTime dueDate, int maxScore)
    {
        Assignment assignment = new Assignment
        {
            Title = title,
            Description = description,
            Category = category,
            DueDate = dueDate,
            MaxScore = maxScore
        };
        assignmentRepository.AddAssignment(assignment);
    }

    public void GradeAssignment(Student student, Assignment assignment, double score, string feedback)
    {

        string letterGrade = GetLetterGrade(score);

        // Update the student's final grade and assignment feedback
        student.FinalGrade = score;
        assignment.Feedback = feedback;

        // Output the graded assignment information
        Console.WriteLine($"Assignment '{assignment.Title}' graded for student {student.LastName}, {student.FirstName}. Score: {score}. Feedback: {feedback}. Final Grade: {letterGrade}");
    }
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