using System;

class Handshake{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        int maxHandshakes = CalculateHandshakes(n);
        Console.WriteLine(maxHandshakes);
    }

    static int CalculateHandshakes(int n){
        return (n * (n - 1)) / 2;
    }
}
