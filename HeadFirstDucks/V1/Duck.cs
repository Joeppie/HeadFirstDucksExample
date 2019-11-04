using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V1
{

    /// <summary>
    /// Interface voor eenden.
    /// Een eend kan vliegen en kwaken.
    /// </summary>
    public abstract class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying away!");
        }
    }

}
