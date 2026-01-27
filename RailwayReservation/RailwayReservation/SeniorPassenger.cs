using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayReservation.RailwayReservation
{
    class SeniorPassenger : Passenger
    {
        public SeniorPassenger(int pnr, string name, int age,int distance)
            : base(pnr, name, age, distance)
        {
        }

        public override string GetCategory()
        {
            return "Senior Citizen";
        }
    }

}
