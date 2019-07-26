using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory.Interfaces
{
    public interface IAbstractProductA
    {
        // Each distinct product of a product family should have a base interface.
        // All variants of the product must implement this interface.
        string UsefulFunctionA();
    }
}
