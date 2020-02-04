using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Store
    {
        Showcase showcase;


        public Store()
        {
            showcase = new Showcase(5);
            Game g1 = new Game("Braid", "TimeyWimey puzzle game", 10);
            //Add Games to the showcase??
        }


        //Buying games
        //Seeing what for sale
    }
}
