using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Interface
{
    // The Command interface declares a method for executing a command.
    public interface ICommand
    {
        void Execute();
    }
}
