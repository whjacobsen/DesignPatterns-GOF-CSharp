using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Interfaces
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
