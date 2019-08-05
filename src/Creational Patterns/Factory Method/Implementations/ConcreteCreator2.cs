using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method.Interfaces;

namespace Factory_Method.Implementations
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
