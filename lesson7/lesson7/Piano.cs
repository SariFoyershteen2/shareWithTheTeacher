using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    public class Piano
    {
        public string Color { get; set; }
        public string Company { get; set; }
        private int age;
        public DateTime Date{ get; set; }

        public int Age
        {
            get { return age; }
            set { if(age>60)
                {
                    throw new old();
                }
            age = value;
                }
        }


        private int price;
        internal string color;
        internal DateTime date;

        public int Price
        {
            get { return price; }
            set
            {
                if (price > 20000)
                {
                    throw new ExspensivePrice();
                }
                price = value;
            }
        }
        //public Piano(string color, string company, int age, DateTime date,  int price)
        //{
        //    this.Color = color;
        //    this.Company = company;
        //    this.Age = age;
        //    this.Date = date;
        //    this.Price = price;
           
        //}
    }
}
