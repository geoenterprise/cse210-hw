using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the teacher interface
        GradingSystem gradingSystem = new GradingSystem();
        TeacherInterface teacherInterface = new TeacherInterface();
        teacherInterface.InitializeAssignmentGrader(gradingSystem);
        teacherInterface.ShowMenu();
    }
}