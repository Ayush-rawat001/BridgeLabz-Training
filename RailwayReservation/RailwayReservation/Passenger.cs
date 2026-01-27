using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayReservation.RailwayReservation
{
    abstract class Passenger
    {
        public int PNR;
        public string Name;
        public int Age;
        public int Distance;
       
        public Passenger(int pnr, string name, int age,int distance)
        {
            PNR = pnr;
            Name = name;
            Age = age;
            Distance = distance;
           
        }

        public abstract string GetCategory();

        public void Display()
        {
            Console.WriteLine("PNR   : " + PNR);
            Console.WriteLine("Name  : " + Name);
            Console.WriteLine("Age   : " + Age);
            Console.WriteLine("Type  : " + GetCategory());
            if (GetCategory() == "Senior Citizen")
            {
                Console.WriteLine("Fair   : " + Distance * 50);
            }
            else
            {
                Console.WriteLine("Fair   : " + Distance * 100);
            }
           Console.WriteLine("-----------------------");
        }  
        

    }

}
