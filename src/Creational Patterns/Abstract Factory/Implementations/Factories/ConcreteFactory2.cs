using System;
using System.Collections.Generic;
using System.Text;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Implementations
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
