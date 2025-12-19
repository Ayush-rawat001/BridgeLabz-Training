// 8. Rewrite the Sample Program 2 with user inputs
// Hint:
// Create variables and take user inputs for name, fromCity, viaCity, toCity.
// Create variables and take user inputs for distances: fromToVia and viaToFinalCity in miles.
// Create variables and take the time taken for the journey.
// Finally, print the results and try to understand operator precedence.
// I/P => name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken
// O/P => The results of the trip are: ___, ___, and ___

using System;
class Trip{
    static void Main(){
        string name = Console.ReadLine();
        string fromCity = Console.ReadLine();
        string viaCity = Console.ReadLine();
        string toCity = Console.ReadLine();
        double fromToVia= double.Parse(Console.ReadLine());
        double viaToFinal = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());
        double totalDist= fromToVia + viaToFinal;
        double avgSpeed = totalDist / time;
        Console.WriteLine("The results of the trip are: Total Distance = " + totalDist +" Time Taken = " + time+" Average Speed = " + avgSpeed);
    }
}
