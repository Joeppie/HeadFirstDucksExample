using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Deze eenden zijn niet zo heel goed geïmplementeerd.
            var badDucks = new List<V1.Duck> { new V1.MallardDuck(), new V1.RubberDuck() };
            foreach (var duck in badDucks)
            {
                    Console.WriteLine(duck.GetType().ToString());
                    Console.Write("\t");
                    duck.Quack();
                    Console.Write("\t");
                    duck.Fly();
            }

            //Deze eenden zijn een stuk netter.
            var goodDucks = new List<V2.Duck> { new V2.MallardDuck(), new V2.RubberDuck() };

            foreach (var duck in goodDucks)
            {
                Console.WriteLine(duck.GetType().ToString());
                Console.Write("\t");
                duck.Quack();
                Console.Write("\t");
                duck.Fly();
            }

            //stop altijd even het programma. (slecht idee in productiecode!)
            Debugger.Break();

            RubberDuckV1WerktOpTweeManierenNietGoed();
        }

        public static void RubberDuckV1WerktOpTweeManierenNietGoed()
        {
            Debugger.Break();
            //Dit 'gaat goed'' maar eigenlijk niet, niet tenzij ik allle implementaties abstract maak (lees weghaal van Duck en er zo eigenlijk een interface van maak!)
            V1.Duck duck1 = new V1.RubberDuck();
            Console.Write("type specifieke 'Duck' implementatie: ");
            duck1.Fly();


            //Deze code werkt wel.. maar dan zou je overal met specifieke types moeten werken...
            V1.RubberDuck duck2 = new V1.RubberDuck();
            Console.Write("type specifieke 'Duck' implementatie: ");
            duck2.Fly();

        }

    }
}
