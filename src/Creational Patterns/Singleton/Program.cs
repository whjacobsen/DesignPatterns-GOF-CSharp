﻿using System;
using System.Threading;
using Singleton.Implementations;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //// The client code. 
            //*Not threadsafe singleton*
            
            //Implementations.Singleton s1 = Implementations.Singleton.GetInstance();
            //Implementations.Singleton s2 = Implementations.Singleton.GetInstance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            //Console.ReadLine();

            // The client code.

            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            Implementations.Singleton singleton = Implementations.Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
