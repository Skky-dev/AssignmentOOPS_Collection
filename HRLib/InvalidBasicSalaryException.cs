using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class InvalidBasicSalaryException : Exception

    {
        public InvalidBasicSalaryException(string message) : base(message)
        {
            
        }
    }
}
