using System;
using Singleton.Implementations;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Implementations.Singleton s1 = Implementations.Singleton.GetInstance();
            Implementations.Singleton s2 = Implementations.Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadLine();
        }
    }
}
