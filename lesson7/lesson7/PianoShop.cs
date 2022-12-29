using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class PianoShop
    {
        public List<Piano> shop { get; set; } = new List<Piano>();
        public PianoShop(List<Piano> shop)
        {
            this.shop = shop;
        }
        public void Checkcolor()
        {
            foreach (Piano p in shop)
            {
                p.ChangeColor();
            }
        }

        public Piano this[int index]

        {
            get
            { return shop[index]; }

            set
            { shop[index] = value; }
        }
    }
}
