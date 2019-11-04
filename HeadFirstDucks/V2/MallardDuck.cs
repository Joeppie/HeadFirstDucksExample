using HeadFirstDucks.V2.Flight;
using HeadFirstDucks.V2.Quack;

namespace HeadFirstDucks.V2
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new QuackBehavior();
            FlightBehavior = new FlightBehavior();
        }
    }

}
