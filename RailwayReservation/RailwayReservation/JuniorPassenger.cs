using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayReservation.RailwayReservation
{
    class JuniorPassenger : Passenger
    {
        public JuniorPassenger(int pnr, string name, int age, int distance)
            : base(pnr, name, age, distance)
        {
        }

      

        public override string GetCategory()
        {
            return "Junior Passenger";
        }
    }

}
