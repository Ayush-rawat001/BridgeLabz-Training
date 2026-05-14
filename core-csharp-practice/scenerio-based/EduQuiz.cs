using System;

class EduQuiz{
    // Method to calculate score and give feedback
    static int CalculateScore(string[] correct, string[] student){
        int score = 0;
        Console.WriteLine("\nQuiz Feedback:\n");

        for (int i = 0; i < correct.Length; i++){
            if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Question " + (i + 1) + ": Correct");
                score++;
            }
            else{
                Console.WriteLine("Question " + (i + 1) + ": Incorrect. Correct answer: " + correct[i]);
            }
        }

        return score;
    }

    // Main method
    static void Main(){
        // Correct answers array
        string[] correctAnswers = { "A", "B", "C", "D", "A", "C", "B", "D", "A", "C" };
        string[] studentAnswers = new string[10];

        Console.WriteLine("Welcome to EduQuiz!");
        Console.WriteLine("Please enter your answers for 10 questions (A/B/C/D):\n");

        // Input student answers
        for (int i = 0; i < studentAnswers.Length; i++) {
            Console.Write("Answer for Question " + (i + 1) + ": ");
            studentAnswers[i] = Console.ReadLine() ?? "";
        }

        // Calculate score
        int totalScore = CalculateScore(correctAnswers, studentAnswers);

        // Calculate percentage
        double percentage = (totalScore * 100.0) / correctAnswers.Length;

        Console.WriteLine("\nTotal Score: " + totalScore + "/" + correctAnswers.Length);
        Console.WriteLine("Percentage: " + percentage + "%");

        // Pass/Fail message
        if (percentage >= 50) {
            Console.WriteLine("Status: Pass");
        }
        else {
            Console.WriteLine("Status: Fail");
        }
    }
}
