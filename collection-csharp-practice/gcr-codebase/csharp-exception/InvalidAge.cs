using System;

//  Create custom exception
class InvalidAgeException : Exception
{
    public InvalidAgeException()
        : base("Age must be 18 or above")
    {
    }
}

class AgeValidator
{
    //  Method to validate age
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException();
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid numeric age.");
        }
    }
}
