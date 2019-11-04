using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V1
{
    public class RubberDuck : Duck
    {
        public void  Fly()
        {
            //Deze eend kan niet vliegen; dus geen implementatie; dat is de netste oplossing.
            //men moet dit gewoon niet aanroepen op deze eend.

            //Echter; met hoe deze code wordt aangeroepen; kan dit niet eens; niet zonder reflection :o
            throw new NotImplementedException();
        }

    }

}
