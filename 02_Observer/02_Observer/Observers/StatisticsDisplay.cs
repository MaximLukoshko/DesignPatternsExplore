using static System.Console;
using _02_Observer.Subject;
using System;

namespace _02_Observer.Observers
{
    class StatisticsDisplay : IDisplay, IObserver
    {
        private float MaxTemperature { get; set; } = float.MinValue;
        private float MinTemperature { get; set; } = float.MaxValue;

        private float MaxHumidity { get; set; } = float.MinValue;
        private float MinHumidity { get; set; } = float.MaxValue;

        private float MaxPressure { get; set; } = float.MinValue;
        private float MinPressure { get; set; } = float.MaxValue;

        private ISubject WheatherDataSubject { get; set; }

        public StatisticsDisplay(ISubject subject)
        {
            WheatherDataSubject = subject;
            WheatherDataSubject.RegisterObserver(this);
        }

        public void Display()
        {
            WriteLine($"MaxTemperature : {MaxTemperature}");
            WriteLine($"MinTemperature : {MinTemperature}");

            WriteLine($"MaxHumidity : {MaxHumidity}");
            WriteLine($"MinHumidity : {MinHumidity}");

            WriteLine($"MaxPressure : {MaxPressure}");
            WriteLine($"MinPressure : {MinPressure}");

            WriteLine();
        }

        public void Update(IWheatherData wheatherData)
        {
            MaxTemperature = Math.Max(MaxTemperature, wheatherData.Temperature);
            MinTemperature = Math.Min(MinTemperature, wheatherData.Temperature);
            MaxHumidity = Math.Max(MaxHumidity, wheatherData.Humidity);
            MinHumidity = Math.Min(MinHumidity, wheatherData.Humidity);
            MaxPressure = Math.Max(MaxPressure, wheatherData.Pressure);
            MinPressure = Math.Min(MinPressure, wheatherData.Pressure);

            Display();
        }
    }
}
