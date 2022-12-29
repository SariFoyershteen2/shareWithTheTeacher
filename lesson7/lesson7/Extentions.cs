using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    public static class Extentions
    {

        public static string ChangeColor(this Piano p)
        {
            string colorr = "blak";
            if (p.color == "white")
                p.color = colorr;
            return p.color;
        }

        public static bool SaleInEffect(this Piano p)
        {
            DateTime d=DateTime.Now;

            if (p.date < d)
            {
                return false;
            }
            return true;
        }
    }
    }

