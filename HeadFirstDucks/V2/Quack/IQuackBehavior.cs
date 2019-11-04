using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDucks.V2
{

    /// <summary>
    /// Interface voor het kwaakgedrag van eenden.
    /// </summary>
    public interface IQuackBehavior
    {
        /// <summary>
        /// Een eend maakt een kwaakgeluid.
        /// </summary>
        void Quack();
    }

}
