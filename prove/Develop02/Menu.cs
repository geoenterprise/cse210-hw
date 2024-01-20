class Menu
{
    //creating my list/array of motivational quotes
    public string[] MotivationalQuotes = {
        "The only way to do great work is to love what you do. - Steve Jobs",
        "Believe you can and you're halfway there. - Theodore Roosevelt",
        "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
        "Psalm 73:26: My flesh and my heart may fail, but God is the strength of my heart and my portion forever", "Nehemiah 8:10: Do not grieve, for the joy of the Lord is your strength"
    };

    public Journal journal; //not sure why I need this line.

    public Menu()
    {
        journal = new Journal();
    }

    public void Run() //running the start of the program code
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool isRunning = true; //used a boolean

        while (isRunning)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteToJournal();
                    break;

                case "2":
                    DisplayJournal();
                    break;

                case "3":
                    SaveToFile();
                    break;

                case "4":
                    LoadFromFile();
                    break;

                case "5":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        Console.WriteLine("Goodbye! Thank you for using the Journal Program.");
    }
    //This section contains the inputs from my options
    public void DisplayRandomQuote()
    {
        // Displaying a random motivational quote from the list/array
        Random random = new Random();
        int index = random.Next(MotivationalQuotes.Length);
        Console.WriteLine("Motivational Quote of the Day:");
        Console.WriteLine(MotivationalQuotes[index]);
        Console.WriteLine();
    }
    private void WriteToJournal()
    {
        Console.WriteLine("You selected: Write");
        DisplayRandomQuote();
        Console.Write("Enter your journal entry: ");        
        string entry = Console.ReadLine();
        journal.WriteEntry(entry);
    }

    private void DisplayJournal()
    {
        Console.WriteLine("You selected: Display");
        journal.DisplayEntries();
    }

    private void SaveToFile()
    {
        Console.WriteLine("You selected: Save to File");
        Journal.SaveToFile(journal.entries);
    }

    private void LoadFromFile()
    {
        Console.WriteLine("You selected: Load from File");
        Console.Write("Enter the file name to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
