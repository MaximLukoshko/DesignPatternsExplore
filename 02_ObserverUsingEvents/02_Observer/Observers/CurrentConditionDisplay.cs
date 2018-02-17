using _02_Observer.Subject;
using static System.Console;

namespace _02_Observer.Observers
{
    class CurrentConditionDisplay : IDisplay, IObserver
    {
        private IWheatherData CurrentWheatherData { get; set; }
        private ISubject WheatherDataSubject { get; set; }

        public CurrentConditionDisplay(ISubject subject)
        {
            WheatherDataSubject = subject;
            WheatherDataSubject.WheatherDataChanged += Update;
        }

        public void Display()
        {
            WriteLine($"Current Temperature: {CurrentWheatherData?.Temperature}");
            WriteLine($"Current Pressure: {CurrentWheatherData?.Pressure}");
            WriteLine($"Current Humidity: {CurrentWheatherData?.Humidity}");
            WriteLine();
        }

        public void Update(object sender, WheatherDataEventArgs args)
        {
            CurrentWheatherData = args.CurrentWheatherData;
            Display();
        }
    }
}
