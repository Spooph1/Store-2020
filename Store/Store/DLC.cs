using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class DLC
    {
        public float price;
        public float SalesPer;
        string name;
        string description;
        Game parentGame;

        public DLC(float price, string name, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;

        }
    }
}
