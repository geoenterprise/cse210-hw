using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What s your grae percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letter = "";
        string modifier = "";
        int grade_remainder = percentage % 10;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage < 90 && percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage < 79 && percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage < 69 && percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade_remainder >= 7)
        {
            modifier = "+";
        }
        else if (grade_remainder <= 3)
        {
            modifier = "-";
        }
        
        if (percentage >= 97 || percentage <=59)
        {
            modifier = "";
        }
       
        Console.WriteLine($"Your grade is {letter}{modifier}");
            
    }
}