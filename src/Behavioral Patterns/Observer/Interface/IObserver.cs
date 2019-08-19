using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interface
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
