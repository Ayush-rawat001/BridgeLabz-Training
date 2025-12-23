using System;

class Program{
    static void Main(){
       int aAmar = Convert.ToInt32(Console.ReadLine());
       int aAkbar = Convert.ToInt32(Console.ReadLine());
       int aAnthony = Convert.ToInt32(Console.ReadLine());
        int hAmar = Convert.ToInt32(Console.ReadLine());
        int hAkbar = Convert.ToInt32(Console.ReadLine());
        int hAnthony = Convert.ToInt32(Console.ReadLine());
        string youngest;
        if (aAmar <= aAkbar && aAmar <= aAnthony){
            youngest = "Amar";
        }
        else if (aAkbar <= aAmar && aAkbar <= aAnthony){
            youngest = "Akbar";
        }
        else{
            youngest = "Anthony";
        }

        
        string tallest;
        if (hAmar >= hAkbar && hAmar >= hAnthony){
            tallest = "Amar";
        }
        else if (hAkbar >= hAmar && hAkbar >= hAnthony) {
            tallest = "Akbar";
        }
        else{
            tallest = "Anthony";
        }
        Console.WriteLine("Youngest Friend: " + youngest);
        Console.WriteLine("Tallest Friend: " + tallest);
    }
}
