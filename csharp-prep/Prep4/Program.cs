using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of all numbers in list is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the list is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        List<int> sortedList = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("Sorted List:");
        foreach (int number in sortedList)
        {
            Console.Write($"{number} ");
        }
    }

}
