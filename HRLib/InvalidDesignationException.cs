using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class InvalidDesignationException : Exception
    {
        public InvalidDesignationException(string message) : base(message) 
        {
            
        }
    }
}
