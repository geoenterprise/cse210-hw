using System.Net.Mail;

class Journal   //This class has my options outputs
{
    public string entries;

    public void WriteEntry(string entry)
    {
        // Registering the entry with date and time
        entries += $"{DateTime.Now}: {entry}\n";
    }

    public void DisplayEntries()
    {
        // Displaying the journal entries
        Console.WriteLine("Journal Entries:");
        Console.WriteLine(entries);
        Console.WriteLine();
    }
    public static void SaveToFile(string entries)
    {
        string filename = "myJournal.csv";
        //Saving entry to my journal file.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.Write(entries);
        }
        //making sure it saves
        Console.WriteLine($"Journal saved to {filename}");
        
    }

    public void LoadFromFile(string filename)
    {
        //loading file by filename
        entries = File.ReadAllText(filename);
        //making sure it loads
        Console.WriteLine($"Journal loaded from {filename}");
               
    }

    
}