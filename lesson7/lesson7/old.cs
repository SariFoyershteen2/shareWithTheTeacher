using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class old:Exception
    {
        public old(string message)
           : base(message)
        {
            // this.Message = message;
        }
        public old()
        {

        }
        public override string Message => "the piano is too old";
    }
}

