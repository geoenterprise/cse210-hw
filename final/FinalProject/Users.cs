using System;
using System.Collections.Generic;
using System.IO;

public class User
{
    // string filePath = "PlantaEstudiantil.csv";
    // Common attributes for all users
    public string LastName { get; set; }
    public string FirstName {get; set; }
    public int ID { get; set; }

    // Constructor
    public User(string lastName, string firstName, int id)
    {
        LastName = lastName;
        FirstName = firstName;
        ID = id;
    }

    // Method to read user data from a CSV file
    public static List<User> ReadFromCSV(string filePath)
    {
        List<User> users = new List<User>();

        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
             
                string[] lines = File.ReadAllLines(filePath);

                bool skipHeader = true;
                foreach (string line in lines)
                {
                    if (skipHeader)
                    {
                        skipHeader = false;
                        continue;
                    }
                    string[] fields = line.Split(',');

                    string lastName = fields[0];
                    string firstName = fields[1];
                    int id = int.Parse(fields[2]);
                    int gradeLevel = int.Parse(fields[3]);
                    int knowledgeGrade = int.Parse(fields[4]);
                    int skillsGrade = int.Parse(fields[5]);
                    int personalDevelopmentGrade = int.Parse(fields[6]);
                    int finalGrade = int.Parse(fields[7]);
                    int gpa = int.Parse(fields[8]);
                                       
                    // Student student = new Student(lastName, firstName, id, gradeLevel, knowledgeGrade, skillsGrade, personalDevelopmentGrade, finalGrade, gpa);
                    
                    users.Add(new User(lastName, firstName, id));
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading the file: " + ex.Message);
        }

        return users;
    }
}