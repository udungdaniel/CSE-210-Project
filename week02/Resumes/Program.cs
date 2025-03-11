using System;
using System.Collections.Generic;

// This class represente a Job
class Job
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        Company = company;
        JobTitle = jobTitle;
        StartYear = startYear;
        EndYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

// This class represente a Resume
class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public Resume(string personName)
    {
        PersonName = personName;
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Resume of {PersonName}");
        Console.WriteLine("-----------------------\n");
        foreach (var job in Jobs)
        {
            job.Display();
        }
        // This line create space at the end of the program
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // This block of code create job instances
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Backend Developer", 2023, 2025);

        // This block of code create resume instance
        Resume myResume = new Resume("Daniel Udung");
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        // calling the resume method
        myResume.Display();
    }
}
