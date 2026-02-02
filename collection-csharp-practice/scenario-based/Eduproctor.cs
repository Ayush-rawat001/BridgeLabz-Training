using System;
using System.Collections.Generic;

class ExamProctor
{
    Stack<int> navigationStack = new Stack<int>();
    Dictionary<int, string> answers = new Dictionary<int, string>();
    Dictionary<int, string> correctAnswers = new Dictionary<int, string>();

    public ExamProctor()
    {
        // Correct answers (QuestionID → Answer)
        correctAnswers.Add(1, "A");
        correctAnswers.Add(2, "B");
        correctAnswers.Add(3, "C");
        correctAnswers.Add(4, "D");
    }

    // Track question navigation
    public void VisitQuestion(int questionId)
    {
        navigationStack.Push(questionId);
        Console.WriteLine("Visited Question: " + questionId);
    }

    // Store answer
    public void SubmitAnswer(int questionId, string answer)
    {
        answers[questionId] = answer;
        Console.WriteLine($"Answer saved for Question {questionId}");
    }

    // Auto-evaluate score
    public int CalculateScore()
    {
        int score = 0;

        foreach (var q in correctAnswers)
        {
            if (answers.ContainsKey(q.Key) && answers[q.Key] == q.Value)
            {
                score++;
            }
        }
        return score;
    }

    // Show last visited question
    public void LastVisitedQuestion()
    {
        if (navigationStack.Count == 0)
        {
            Console.WriteLine("No questions visited.");
            return;
        }
        Console.WriteLine("Last Visited Question: " + navigationStack.Peek());
    }
}

class Program
{
    static void Main()
    {
        ExamProctor exam = new ExamProctor();

        exam.VisitQuestion(1);
        exam.SubmitAnswer(1, "A");

        exam.VisitQuestion(2);
        exam.SubmitAnswer(2, "C");

        exam.VisitQuestion(3);
        exam.SubmitAnswer(3, "C");

        exam.LastVisitedQuestion();

        int score = exam.CalculateScore();
        Console.WriteLine("Final Score: " + score);
    }
}
