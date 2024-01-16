using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int myNumber = randomGenerator.Next(1, 100);
        Console.Write("What number am I thinking of? ");
        string answer = Console.ReadLine();
        int guess = int.Parse(answer);
        int attempts = 1;
        if (myNumber == guess)
        {
            Console.WriteLine("Awesome guess");
        }
        while (myNumber != guess)
        {
            Console.Write("What is your new guess? ");
            guess = int.Parse(Console.ReadLine());
            if (myNumber < guess)
            {
                Console.WriteLine("Sorry try a lower number.");
                attempts += 1;
            }
            else if (myNumber > guess)
            {
                Console.WriteLine("Sorry try a higher number. ");
                attempts += 1;
            }
            else 
            {
                Console.WriteLine("Good job you guessed it.");
                attempts += 1;
            }
                                    
        }
        Console.WriteLine($"You tried {attempts} times.");
                       
    }
}