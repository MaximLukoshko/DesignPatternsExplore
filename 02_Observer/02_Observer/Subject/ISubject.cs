using _02_Observer.Observers;

namespace _02_Observer.Subject
{
    interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyAll();
    }
}
