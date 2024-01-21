using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._jobTitle="QA Engineer";
        job1._company = "Accenture";
        job1._startYear= 2021;
        job1._endYear = 2023;

        Jobs job2 = new Jobs();
        job2._jobTitle = "Software Engineer";
        job2._company = "IBM";
        job2._startYear = 2019;
        job2._endYear = 2021;


        Resume resume1 = new Resume();
        resume1._name = "Alejandra Gomez";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.displayResumeInformation();
    }
}