using _02_Observer.Observers;
using System;
using System.Collections.Generic;

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
                OnWheatherDataChanged(new WheatherDataEventArgs(this));
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


        public event EventHandler<WheatherDataEventArgs> WheatherDataChanged;

        protected virtual void OnWheatherDataChanged(WheatherDataEventArgs args)
        {
            WheatherDataChanged?.Invoke(this, args);
        }

        private ICollection<IObserver> Observers { get; } = new List<IObserver>();
    }
}
