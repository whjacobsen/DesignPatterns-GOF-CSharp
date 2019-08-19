using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Implementations
{
    // Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
}
