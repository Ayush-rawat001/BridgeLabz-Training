using System;

class Calculator{
    static void Main(){
    double first = Convert.ToDouble(Console.ReadLine());
    double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();

        double result = 0;
       switch (op)
        {
            case "+":
                result = first + second;
                Console.WriteLine("Result: " + result);
                break;

            case "-":
                result = first - second;
                Console.WriteLine("Result: " + result);
                break;

            case "*":
                result = first * second;
                Console.WriteLine("Result: " + result);
                break;

            case "/":
                if (second != 0){
                    result = first / second;
                    Console.WriteLine("Result: " + result);
                }
                else{
                    Console.WriteLine("Error");
                    
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
             }
             }
}
