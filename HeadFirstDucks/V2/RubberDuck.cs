using HeadFirstDucks.V2.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V2
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new SqueakBehavior();
        }
     
    }

}
