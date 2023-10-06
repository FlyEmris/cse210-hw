using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._title = 'Lifeguard';
        job1._company = 'Ymca';
        job1._yearStart = 2015;
        job1._yearEnd = 2017;

        Job job2 = new Job():
        job2._title = 'construction';
        job2._company = 'J&M Construction';
        job2._yearStart = 2021;
        job2._yearStart = 2023;


        Resume myResume = new Resume();
        myResume._name = "Jonathan Leonardson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}