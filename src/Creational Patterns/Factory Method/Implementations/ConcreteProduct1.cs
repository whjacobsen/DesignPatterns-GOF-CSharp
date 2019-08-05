using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method.Implementations
{
    // Concrete Products provide various implementations of the Product
    // interface.
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
