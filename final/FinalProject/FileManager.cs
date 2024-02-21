using System;
using System.Collections.Generic;
using System.IO;

public class FileManager
{
    // public string filePath = "PlantaEstudiantil.csv";
    // Method to read student data from a CSV file
    public List<Student> ReadStudentsFromCSV(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the CSV file
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

                    // Create a new student object and add it to the list
                    students.Add(new Student(lastName, firstName, id, gradeLevel, knowledgeGrade, skillsGrade, personalDevelopmentGrade, finalGrade, gpa));
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

        return students;
    }

    // Method to write student data to a CSV file
    public void WriteStudentsToCSV(string filePath, List<Student> students)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("PlantaEstudiantil.csv"))
            {
                // Write header
                writer.WriteLine("Name,ID,GradeLevel,GPA");

                // Write student data
                foreach (Student student in students)
                {
                    writer.WriteLine($"{student.LastName},{student.FirstName},{student.ID},{student.GradeLevel},{student.KnowledgeGrade},{student.SkillsGrade},{student.PersonalDevelopmentGrade},{student.FinalGrade},{student.GPA}");
                }
            }

            Console.WriteLine("Student data has been successfully written to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
        }
    }

    // Method to read teacher data from a CSV file
    public List<Teacher> ReadTeachersFromCSV(string filePath2)
    {
        List<Teacher> teachers = new List<Teacher>();

        try
        {
            if (File.Exists(filePath2))
            {
                string[] lines = File.ReadAllLines(filePath2);

                for (int i = 1; i < lines.Length; i++)
                {
                    // Split the line into fields
                    string[] fields = lines[i].Split(',');

                    string lastName = fields[0];
                    string firstName = fields[1];
                    int id = int.Parse(fields[2]);
                    string subject = fields[3];
                    int yearsOfExperience = int.Parse(fields[4]);

                    teachers.Add(new Teacher(lastName, firstName, id, subject, yearsOfExperience));
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

        return teachers;
    }

    // Method to write teacher data to a CSV file
    public void WriteTeachersToCSV(string filePath, List<Teacher> teachers)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("PlantaDocentes.csv"))
            {
                // Write header
                writer.WriteLine("Name,ID,Subject,YearsOfExperience");

                // Write teacher data
                foreach (var teacher in teachers)
                {
                    writer.WriteLine($"{teacher.LastName},{teacher.FirstName},{teacher.ID},{teacher.Subject},{teacher.YearsOfExperience}");
                }
            }

            Console.WriteLine("Teacher data has been successfully written to the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
        }
    }
}