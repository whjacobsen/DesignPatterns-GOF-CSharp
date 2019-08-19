using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Implementations
{
    class ConcreteComponent : Component
    {
        // Concrete Components provide default implementations of the operations.
        // There might be several variations of these classes.
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
