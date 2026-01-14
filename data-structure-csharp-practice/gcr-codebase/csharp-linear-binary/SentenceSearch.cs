using System;

class SentenceSearch
{
    static void Main()
    {
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine().ToLower();

        bool isFound = false;

        for (int i = 0; i < n; i++)
        {
            if (sentences[i].ToLower().Contains(word))
            {
                Console.WriteLine("Sentence found:");
                Console.WriteLine(sentences[i]);
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No sentence contains the given word.");
        }
    }
}
