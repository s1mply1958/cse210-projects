using System;

public class Resume
{
    public string _name;
    // Corrections from sample solution
    public List<Job> _jobs = new List<Job>();
    public void Display()

    {
        Console.WriteLine($"Name: {_name}\nJobs: ");

        // Corrections from sample solution
        foreach (Job job in _jobs)
        {

        // Corrections from sample solution
            job.Display();

        }
    }
}