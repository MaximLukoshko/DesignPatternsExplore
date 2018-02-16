using _02_Observer.Observers;
using System.Collections.Generic;
using System.Linq;

namespace _02_Observer.Subject
{
    class WheatherData : ISubject, IWheatherData
    {
        public WheatherData() { }

        private void SetNewValueAndNotify<T>(ref T currentValue, T newValue)
        {
            if (!currentValue.Equals(newValue))
            {
                currentValue = newValue;
                NotifyAll();
            }
        }

        float _temperature;
        public float Temperature
        {
            get => _temperature;
            set => SetNewValueAndNotify(ref _temperature, value);
        }

        float _humidity;
        public float Humidity
        {
            get => _humidity;
            set => SetNewValueAndNotify(ref _humidity, value);
        }

        float _pressure;
        public float Pressure
        {
            get => _pressure;
            set => SetNewValueAndNotify(ref _pressure, value);
        }


        private ICollection<IObserver> Observers { get; } = new List<IObserver>();

        public void NotifyAll()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }

            if (Observers.Any())
            {
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
