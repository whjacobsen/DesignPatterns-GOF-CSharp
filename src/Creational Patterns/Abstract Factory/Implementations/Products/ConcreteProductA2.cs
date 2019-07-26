using Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Implementations
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
