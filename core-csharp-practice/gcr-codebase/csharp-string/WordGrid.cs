using System;

class WordGrid{
    static void Main(){
      
        string str = Console.ReadLine();

        // Check for null
        if (str == null || str == "")
        {
            Console.WriteLine("Empty input!");
            return;
        }

        // Count words manually
        int wordCount = 1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ') wordCount++;
        }

        //Create 2D array 
        string[,] grid = new string[wordCount, 2];

        string temp = "";  // Temporary word
        int row = 0;       // Current row

        // Loop through each character 
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                grid[row, 0] = temp;

                // Count characters 
                int length = 0;
                foreach (char ch in temp) length++;
                grid[row, 1] = length.ToString();

                temp = "";
                row++;
            }
            else
            {
                temp += str[i];
            }
        }

        // Store last word
        grid[row, 0] = temp;
        int lastLength = 0;
        foreach (char ch in temp) lastLength++;
        grid[row, 1] = lastLength.ToString();

        // Print words and lengths
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            Console.WriteLine(grid[i, 0] + " -> " + grid[i, 1]);
        }
    }
}
