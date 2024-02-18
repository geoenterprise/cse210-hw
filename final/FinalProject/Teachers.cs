public class Teacher : User
{
    // Teacher-specific attributes
    public string Subject { get; set; }
    public int YearsOfExperience { get; set; }

    // Constructor
    public Teacher(string lastName, string firstName, int id, string subject, int yearsOfExperience) : base(lastName, firstName, id)
    {
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
    }

    // Method to display teacher information
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {LastName}, ID: {ID}, Subject: {Subject}, Years of Experience: {YearsOfExperience}");
    }
}