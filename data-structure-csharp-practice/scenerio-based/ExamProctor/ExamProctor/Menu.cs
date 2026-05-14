using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor.ExamProctor
{
    internal class Menu
    {
        public void Start()
        {
            List<Question> questions = new List<Question>()
            {
              new Question(1, "D"),
              new Question(2, "B"),
              new Question(3, "C"),
              new Question(5, "D"),
              new Question(6, "C"),
              new Question(7, "B"),
              new Question(8, "A"),
            };
             
            Navigation nav = new Navigation();
            Evaluate eval = new Evaluate();
            Answer ans = new Answer();
            Console.WriteLine(" ---------------");
            Console.WriteLine("|  Exam Proctor |");
            Console.WriteLine(" ---------------\n");

            while (true)
            {
                Console.WriteLine("1. Visit Question");
                Console.WriteLine("2. Answer Question");
                Console.WriteLine("3. Go Back (Stack)");
                Console.WriteLine("4. Submit Exam");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Question ID: ");
                        int qid = int.Parse(Console.ReadLine());
                        nav.Visit(qid);
                        Console.WriteLine("Visited Question " + qid);
                        break;
                    case 2:
                        Console.Write("Enter Question ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Answer (A/B/C/D): ");
                        string answer = Console.ReadLine().ToUpper();

                        ans.SaveAnswer(id, answer);
                        Console.WriteLine("Answer Saved.");
                        break;

                    case 3:
                        int previous = nav.GoBack();

                        if (previous == -1)
                            Console.WriteLine("No previous question.");
                        else
                            Console.WriteLine("Returned to Question " + previous);
                        break;

                    case 4:
                        int score = eval.CalculateScore(
                            questions,
                             ans.GetAnswers());

                        Console.WriteLine("\n=======================");
                        Console.WriteLine(" EXAM SUBMITTED ");
                        Console.WriteLine("=======================");
                        Console.WriteLine("Score: " + score + "/" + questions.Count);
                        return;

                    case 5:
                        return;
                }


            }
        }
    }
}
