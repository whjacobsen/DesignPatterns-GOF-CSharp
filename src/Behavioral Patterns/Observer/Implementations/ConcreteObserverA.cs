﻿using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Implementations
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}