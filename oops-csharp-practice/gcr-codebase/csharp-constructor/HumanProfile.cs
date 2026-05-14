using System;

class HumanProfile
{
    private string name;
    private int age;

    public HumanProfile(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public HumanProfile(HumanProfile other)
    {
        name = other.name;
        age = other.age;
    }

    public void PrintPerson()
    {
        Console.WriteLine($"\n[Person Copy]\nName: {name}\nAge: {age}\n");
    }

    public static void Main()
    {
        HumanProfile p1 = new HumanProfile("Amit", 28);
        p1.PrintPerson();

        HumanProfile p2 = new HumanProfile(p1);// cloning
        p2.PrintPerson();
    }
}
