using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class ExspensivePrice: Exception
    {
        public ExspensivePrice(string message)
           : base(message)
        {
            // this.Message = message;
        }
        public ExspensivePrice()
        {

        }
        public override string Message => "the piano is above the desired price";
    }
    
}
