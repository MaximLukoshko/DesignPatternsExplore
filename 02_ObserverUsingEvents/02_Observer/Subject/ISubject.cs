using System;

namespace _02_Observer.Subject
{
    interface ISubject
    {
        event EventHandler<WheatherDataEventArgs> WheatherDataChanged;
    }
}
