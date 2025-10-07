using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7._10._25.Exceptions;

public class CapacityLimitException : Exception
{
    public CapacityLimitException(string message) : base(message)
    {
    }
}
