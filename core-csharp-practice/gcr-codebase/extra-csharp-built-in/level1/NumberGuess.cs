using System;

class Game1 {
    static Random r = new Random();
    static int Guess() => r.Next(1, 101);
    static string Feedback() => Console.ReadLine();

    static void Main() {
        string fb;
        do {
            Console.WriteLine("Guess: " + Guess());
            Console.Write("High / Low / Correct: ");
            fb = Feedback().ToLower().Trim();
        } while (!fb.Equals("correct"));
        Console.WriteLine("Guessed right!");
    }
}
