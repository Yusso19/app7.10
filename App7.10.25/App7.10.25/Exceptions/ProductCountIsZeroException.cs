using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7._10._25.Exceptions
{
    public class ProductCountIsZeroException : Exception 
    {
        public ProductCountIsZeroException(string message) : base(message)
        {
        }
    }
}
