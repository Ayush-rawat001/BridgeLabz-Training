using System;

// Base class
class Vehicle
{
    public int MaxSpeed;
    public string FuelType;

    public Vehicle(int maxSpeed, string fuelType)
    {
        this.MaxSpeed = maxSpeed;
        this.FuelType = fuelType;
    }

    // Virtual method to display vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Info - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
    }
}

// Car subclass
class Car : Vehicle
{
    public int SeatCapacity;

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        this.SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Car - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Seats: {SeatCapacity}");
    }
}

// Truck subclass
class Truck : Vehicle
{
    public int PayloadCapacity;

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        this.PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Payload: {PayloadCapacity} kg");
    }
}

// Motorcycle subclass
class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        this.HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle - Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}, Sidecar: {HasSidecar}");
    }
}

// Main program
class VehicleProgram
{
    public static void Main()
    {
        // Create an array of Vehicle type
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 5000);
        vehicles[2] = new Motorcycle(150, "Petrol", true);

        // Polymorphism : dynamic method dispatch
        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
        }
    }
}
