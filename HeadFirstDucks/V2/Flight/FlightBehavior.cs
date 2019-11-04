using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V2.Flight
{
    class FlightBehavior : IFlightBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }
}
