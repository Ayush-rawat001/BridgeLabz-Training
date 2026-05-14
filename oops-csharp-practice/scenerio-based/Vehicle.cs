public interface IRentable //interface
{
    public int calculateRent(int days);
}
abstract class Vehicle : IRentable //parent class
{
    protected string vehicleType;
    protected double DayRent;

    public Vehicle(string type, double rate)
    {
        this.vehicleType = type;
        this.perDayRent = rate;
    }

    public virtual double CalculateRent(int days)
    {
        return days * perDayRent;
    }

   
}
class Bike : Vehicle
{
    public Bike() : base("Bike", 200) { } //parent constructor calling
}

class Car : Vehicle
{
    public Car() : base("Car", 500) { } //parent constructor calling
}

class Truck : Vehicle
{
    public Truck() : base("Truck", 900) { } //parent constructor calling
}
//customer class
class Customer
{
    private string renter;
    private int totalDays;

    public Customer(string name, int days)
    {
        this.renter = name;
        this.totalDays = days;
    }

// method to print bill 
    public void PrintBill(Vehicle v)
    {
       
        Console.WriteLine($"Customer Name: {renter}");
        Console.WriteLine($"Rental Days: {totalDays}");
        Console.WriteLine($"Total Amount: ₹{v.CalculateRent(totalDays)}");
        
    }
}

class RentalApp
{
    static void Main()
    {
        Vehicle[] options = new Vehicle[] //array of each vehicle object
        {
            new Bike(),
            new Car(),
            new Truck()
        };

        Customer user1 = new Customer("Ayush ", 4);
        Customer user2 = new Customer("Aman", 2);

        user1.PrintBill(options[1]); // Car rented
        user2.PrintBill(options[0]); // Bike rented
        user2.PrintBill(options[2]);// truck rented
    }
}