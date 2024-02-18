using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the teacher interface
        TeacherInterface teacherInterface = new TeacherInterface();

        teacherInterface.ShowMenu();
    }
}