using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Implementations
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
