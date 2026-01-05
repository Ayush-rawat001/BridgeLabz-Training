using System;

class StayBooking
{
    private string guest;
    private string room;
    private int days;

    public StayBooking() : this("Not Assigned", "Standard", 1) { }//default

    public StayBooking(string guest, string room, int days)
    {
        this.guest = guest;
        this.room = room;
        this.days = days;
    }

    public StayBooking(StayBooking old)//copy constructor
    {
        guest = old.guest;
        room = old.room;
        days = old.days;
    }

    public void Print()// method to print
    {
        Console.WriteLine($"\n[Booking Details]\nGuest: {guest}\nRoom: {room}\nNights: {days}\n");
    }

    public static void Main()
    {
        StayBooking s1 = new StayBooking();
        s1.Print();

        StayBooking s2 = new StayBooking("Rohan", "Deluxe", 5);
        s2.Print();

        StayBooking s3 = new StayBooking(s2);
        s3.Print();
    }
}
