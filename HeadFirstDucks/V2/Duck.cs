using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V2
{
    
    public class Duck
    {
        /// <summary>
        /// Alleen specifieke Eend implementaties mogen een kwaakimplementatie instellen
        /// <note>Mag null blijven.</note>
        /// </summary>
        public IQuackBehavior QuackBehavior { private get; set; }
        /// <summary>
        /// Alleen specifieke Eend implementaties mogen een vliegimplementatie instellen
        /// <note>Mag null blijven.</note>
        /// </summary>
        public IFlightBehavior FlightBehavior{ private get; set; }

        /// <summary>
        /// Laat de eend kwaken.
        /// </summary>
        public void Quack()
        {
            if (QuackBehavior != null)
            {
                QuackBehavior.Quack();
            }
        }

        /// <summary>
        /// Laat de eend vliegen.
        /// </summary>
        public void Fly()
        {
            if (FlightBehavior != null)
            {
                FlightBehavior.Fly();
            }
        }

    }

}
