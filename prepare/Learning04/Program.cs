using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Geo", "Programming with Classes");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Geo", "Programming with Classes", "4.5", "pages 15-29");
        string homeworkList = mathAssignment.GetHomeworkList();
        //Console.WriteLine(summary);
        Console.WriteLine(homeworkList);
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Geo", "C#", "Book of Mormon");
        string writingInfo = writingAssignment.GetWritingInfo();
        //Console.WriteLine(summary);
        Console.WriteLine(writingInfo);
        Console.WriteLine();

    }
}