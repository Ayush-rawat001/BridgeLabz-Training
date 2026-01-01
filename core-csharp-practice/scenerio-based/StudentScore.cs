using System;

class StudentScore{
    static int[] marks;
    static int n = 0;

    // input scores
    public static void AddMarks() {
        Console.Write("Number of students: ");
        n = Convert.ToInt32(Console.ReadLine());

        marks = new int[n];

        for (int i = 0; i < n; i++){
            int val = -1;
            while (val < 0) {
                Console.Write("Mark for student " + (i + 1) + ": ");
                val = Convert.ToInt32(Console.ReadLine());

                if (val < 0){
                    Console.WriteLine("No negative marks!");
                }
            }
            marks[i] = val;
        }

        Console.WriteLine("Saved!");
    }

    // average
    public static void ShowAvg() {
        if (marks == null || n == 0){
            Console.WriteLine("No data!");
            return;
        }

        int sum = 0;
        for (int i = 0; i < n; i++){
            sum += marks[i];
        }

        float avg = (float)sum / n;
        Console.WriteLine("Average = " + avg);
    }

    // highest and lowest
    public static void HighLow(){
        if (marks == null || n == 0){
            Console.WriteLine("No data!");
            return;
        }

        int high = marks[0];
        int low = marks[0];

        for (int i = 1; i < n; i++){
            if (marks[i] > high) high = marks[i];
            if (marks[i] < low) low = marks[i];
        }

        Console.WriteLine("Highest = " + high);
        Console.WriteLine("Lowest = " + low);
    }

    // above average
 public static void AboveAvg(){
        if (marks == null || n == 0){
            Console.WriteLine("No data!");
            return;
        }

        int sum = 0;
        for (int i = 0; i < n; i++){
            sum += marks[i];
        }


        float avg = (float)sum / n;
        Console.WriteLine("Average = " + avg);

        Console.WriteLine("Marks above average:");
        bool found = false;

        for (int i = 0; i < n; i++){
            if (marks[i] > avg) {
                Console.WriteLine(marks[i]);
                found = true;
            }
        }

        if (!found) Console.WriteLine("None!");
    }








    // main with menu
    public static void Main(){
        while (true) {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 Add marks");
            Console.WriteLine("2 Average");
            Console.WriteLine("3 High & Low");
            Console.WriteLine("4 Above Average");
            Console.WriteLine("5 Exit");
            Console.Write("Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) AddMarks();
            else if (choice == 2) ShowAvg();
            else if (choice == 3) HighLow();
            else if (choice == 4) AboveAvg();
            else if (choice == 5) break;
            else Console.WriteLine("Wrong choice!");
        }

        Console.WriteLine("Bye!");
    }
}
