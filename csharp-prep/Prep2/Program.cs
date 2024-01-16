using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What s your grae percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);
        if (x >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if (x < 90 && x >= 80)
        {
            Console.WriteLine("Your grade is B");

        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

            

    }
}