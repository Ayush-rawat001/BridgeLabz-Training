using System;
class Countdown{
    static void Main(){
    int counter = Convert.ToInt32(Console.ReadLine());
    while (counter >= 1){
            Console.WriteLine(counter);
            counter--;
        }
    }
}
