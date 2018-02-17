using _02_Observer.Subject;
using static System.Console;

namespace _02_Observer.Observers
{
    class HeatIndexDisplay : IDisplay, IObserver
    {
        private float HeatIndex { get; set; }

        private ISubject WheatherDataSubject { get; set; }

        public HeatIndexDisplay(ISubject subject)
        {
            WheatherDataSubject = subject;
            WheatherDataSubject.WheatherDataChanged += Update;
        }

        public void Display()
        {
            WriteLine($"Heat Index: {HeatIndex}");
            WriteLine();
        }

        public void Update(object sender, WheatherDataEventArgs args)
        {
            var wheatherData = args.CurrentWheatherData;
            HeatIndex = 16.92f + 1.85f * wheatherData.Temperature + 5.38f * wheatherData.Humidity - 
                wheatherData.Temperature * wheatherData.Humidity;
            Display();
        }
    }
}
