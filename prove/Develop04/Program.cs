using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                    break;
            }

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;

                case "2":
                    RunReflectionActivity();
                    break;

                case "3":
                    RunListingActivity();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;


            }

        }
        // BreathingActivity breathingActivity = new BreathingActivity();
        // ReflectionActivity reflectionActivity = new ReflectionActivity();
        // ListingActivity listingActivity = new ListingActivity();

        // MainActivity[] activities = { breathingActivity, reflectionActivity, listingActivity};

        // foreach (var activity in activities)
        // {
        //     activity.StartActivity();

        // }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Mindfulness Activities Menu");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine("");
        Console.Write("Choose an activity (1-4): ");
    }
    static void RunBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.RunBreathingActivity();
        // breathingActivity.SetDuration(20);
    }
    static void RunReflectionActivity()
    {
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.RunReflectionActivity();
    }
    static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.RunListingActivity();

    }

}