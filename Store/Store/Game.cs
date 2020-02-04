using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Game
    {

        string[] Genre;
        public float price;
        public float salesPer;
        public List<DLC> dlcs;
        string name;
        string description;
        string systemrequirements;
        int metacritic;

        public Game(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
