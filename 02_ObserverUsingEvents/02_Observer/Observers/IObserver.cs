using _02_Observer.Subject;

namespace _02_Observer.Observers
{
    interface IObserver
    {
        void Update(object sender, WheatherDataEventArgs args);
    }
}
