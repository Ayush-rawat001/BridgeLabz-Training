using System;

//interface
public interface IFlyable
{
    bool Fly();

}
//interface
public interface ISwimmable
{
    bool Swim();
}
//abstract class
abstract class Bird : IFlyable , ISwimmable
{
    //name attribute
    public string name;
    public Bird(string name)//constructor
    {
        this.name = name;
    }


    //method to DisplayProperties properties
    public void DisplayProperties()
    {
        if(Fly() == true && Swim() == false)
        {
            Console.WriteLine(name + " Can Fly");
        }
        else if(Swim() == true && Fly() == false)
        {
            Console.WriteLine(name+" can swim");
        }
        else if(Swim() == true && Fly() == true)
        {
            Console.WriteLine(name+" can fly and swim both");
        }

    }
    public abstract bool Fly();
    public abstract bool Swim();


}

//Sparrow class
class Sparrow : Bird
{
    public Sparrow() : base("Sparrow") { }//calling base class constructor

    public override bool Fly()//implementing abstract method
    {
        return true;
    }

    public override bool Swim()//implementing abstract method
    {
        return false;
    }
}
//eagle class
class Eagle : Bird
{
    public Eagle() : base("Eagle") { }//calling base class constructor

    public override bool Fly()//implementing abstract method
    {
        return true;    
    }

    public override bool Swim()//implementing abstract method
    {
        return false;
    }
}
//duck class
class Duck : Bird
{
    public Duck() : base("Duck") { }//calling base class constructor

    public override bool Fly()//implementing abstract method
    {
        return false;
    }

    public override bool Swim()//implementing abstract method
    {
        return true;
    }

}

//seagull class
class Seagull : Bird
{
    public Seagull() : base("Seagull") { }//calling base class constructor

    public override bool Fly()//implementing abstract method
    {
        return true;
    }

    public override bool Swim()//implementing abstract method
    {
        return true;
    }
}
//penguin class
class Penguin : Bird
{
    public Penguin() : base("Penguin") { }//calling base class constructor

    public override bool Fly()//implementing abstract method
    {
        return false;
    }

    public override bool Swim()//implementing abstract method
    {
        return true;
    }
}

class Sanctuary
{
    public static void Main(string[] args)
    { 
        //creating object of every class
        Bird[] sanctuary = new Bird[]
        {
            new Eagle(),new Sparrow(),new Duck(),new Penguin(),new Seagull()
        };
        foreach (Bird bird in sanctuary)
        {
            bird.DisplayProperties();
        }
    }
}