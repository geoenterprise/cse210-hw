using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

// public class Resume
// {
//     string name = "";
//     List<Job> jobs = new List<Job>();


//     public void Display()
//     {
//         Console.WriteLine($"Resume for {name}");
//         foreach (var job in jobs)
//         {
//             job.Jobinfo();
//         }
//     }
// }
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engeniier";
        job1._company = "BYU Idaho";
        job1._startYear = "2021";
        job1._endYear = "2023";
 
        job1.JobInfo();

        Job job2 = new Job();
        job2._jobTitle = "ESL English Teacher";
        job2._company = "English School";
        job2._startYear = "2023";
        job2._endYear = "2024";

        job2.JobInfo();

        Resume myResume = new Resume();
        myResume._name = "Geo Rey";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


        // Console.WriteLine("Hello Learning02 World!");
    }
}