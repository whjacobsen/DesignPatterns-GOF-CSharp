using Adapter.Implementations;
using Adapter.Interfaces;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Implementations.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.ReadLine();
        }
    }
}
