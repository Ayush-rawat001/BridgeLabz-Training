using System;

// Superclass
class Creature
{
    public string Name;
    public int Age;

    public Creature(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Method to make a sound (can be changed by subclasses)
    public virtual void MakeNoise()
    {
        Console.WriteLine("Creature makes a sound");
    }
}

// Subclass Puppy
class Puppy : Creature
{
    public Puppy(string name, int age) : base(name, age) { }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the Puppy barks!");
    }
}

// Subclass Kitten
class Kitten : Creature
{
    public Kitten(string name, int age) : base(name, age) { }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the Kitten meows!");
    }
}

// Subclass Birdie
class Birdie : Creature
{
    public Birdie(string name, int age) : base(name, age) { }

    public override void MakeNoise()
    {
        Console.WriteLine($"{Name} the Bird chirps!");
    }
}

// Main Program
class AnimalProgram
{
    public static void Main()
    {
        // Create one object for each animal
        Creature dog = new Puppy("Rex", 3);
        Creature cat = new Kitten("Mimi", 2);
        Creature bird = new Birdie("Tweety", 1);

        // Call MakeNoise() for each animal
        dog.MakeNoise();
        cat.MakeNoise();
        bird.MakeNoise();
    }
}
