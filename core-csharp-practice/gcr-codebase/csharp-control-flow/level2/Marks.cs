using System;

class Marks{
    static void Main(){
       int physics = Convert.ToInt32(Console.ReadLine());
       int chemistry = Convert.ToInt32(Console.ReadLine());
       int maths = Convert.ToInt32(Console.ReadLine());
       int total = physics + chemistry + maths;
       double average = total / 3.0;
       Console.WriteLine("Average Marks = " + average);

        if (average >= 80){
            Console.WriteLine("Grade: A");
            Console.WriteLine("Remarks: Level 4, above agency-normalized standards");
        }
        else if (average >= 70){
            Console.WriteLine("Grade: B");
            Console.WriteLine("Remarks: Level 3, at agency-normalized standards");
        }
        else if (average >= 60){
            Console.WriteLine("Grade: C");
            Console.WriteLine("Remarks: Level 2, below but  approaching  agency-normalized  standards");
        }
        else if (average >= 50){
            Console.WriteLine("Grade: D");
            Console.WriteLine("Remarks: Level 1, well below  agency-normalized  standards");
        }
        else if (average >= 40) {
            Console.WriteLine("Grade: E");
            Console.WriteLine("Remarks: Level 1-, too below agency-normalized standards");
        }
        else {
            Console.WriteLine("Grade: R");
            Console.WriteLine("Remarks: Remedial standards");
        }
    }
}
