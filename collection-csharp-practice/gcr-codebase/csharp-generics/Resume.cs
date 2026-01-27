using System;
using System.Collections.Generic;

namespace ResumeScreeningSystem
{
    
    // Abstract base class
    
    abstract class JobRole
    {
        public string CandidateName { get; set; }
        public int Experience { get; set; }

        // Abstract method
        public abstract void Evaluate();
    }

  
    // Software Engineer role

    class SoftwareEngineer : JobRole
    {
        public string ProgrammingLanguage { get; set; }

        public override void Evaluate()
        {
            Console.WriteLine("Evaluating Software Engineer Resume");
            Console.WriteLine("Candidate: " + CandidateName);
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Language: " + ProgrammingLanguage);

            if (Experience >= 2)
                Console.WriteLine("Result: Selected\n");
            else
                Console.WriteLine("Result: Rejected\n");
        }
    }

    // -------------------------------
    // Data Scientist role
    // -------------------------------
    class DataScientist : JobRole
    {
        public string Tool { get; set; }

        public override void Evaluate()
        {
            Console.WriteLine("Evaluating Data Scientist Resume");
            Console.WriteLine("Candidate: " + CandidateName);
            Console.WriteLine("Experience: " + Experience + " years");
            Console.WriteLine("Tool: " + Tool);

            if (Experience >= 1)
                Console.WriteLine("Result: Selected\n");
            else
                Console.WriteLine("Result: Rejected\n");
        }
    }


    // Generic Resume class with constraint
  
    class Resume<T> where T : JobRole
    {
        private List<T> resumes = new List<T>();

        // Add resume
        public void AddResume(T resume)
        {
            resumes.Add(resume);
        }

        // Screen all resumes
        public void ScreenResumes()
        {
            Console.WriteLine("------ Resume Screening Started ------\n");

            foreach (T resume in resumes)
            {
                resume.Evaluate();
            }

            Console.WriteLine("------ Screening Completed ------");
        }
    }


    // Main Program

    class Program
    {
        static void Main(string[] args)
        {
            // Software Engineer resumes
            Resume<SoftwareEngineer> softwareResume =
                new Resume<SoftwareEngineer>();

            softwareResume.AddResume(new SoftwareEngineer
            {
                CandidateName = "Ayush",
                Experience = 3,
                ProgrammingLanguage = "C#"
            });

            softwareResume.AddResume(new SoftwareEngineer
            {
                CandidateName = "Rohit",
                Experience = 1,
                ProgrammingLanguage = "Java"
            });

            // Data Scientist resumes
            Resume<DataScientist> dataResume =
                new Resume<DataScientist>();

            dataResume.AddResume(new DataScientist
            {
                CandidateName = "Anjali",
                Experience = 2,
                Tool = "Python"
            });

            dataResume.AddResume(new DataScientist
            {
                CandidateName = "Karan",
                Experience = 0,
                Tool = "Excel"
            });

            // Screening
            softwareResume.ScreenResumes();
            Console.WriteLine();
            dataResume.ScreenResumes();

            Console.ReadLine();
        }
    }
}
