using _02_Observer.Observers;
using _02_Observer.Subject;

namespace _02_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var wheatherData = new WheatherData
            {
                Temperature = 15.25f,
                Pressure = 25.25f,
                Humidity = 28.11f
            };

            var conditionDisplay = new CurrentConditionDisplay(wheatherData);
            var statisticsDisplay = new StatisticsDisplay(wheatherData);
            var heatIndexDisplay = new HeatIndexDisplay(wheatherData);

            wheatherData.Humidity = 32.11f;

            wheatherData.WheatherDataChanged -= statisticsDisplay.Update;
            wheatherData.Pressure = 35.99f;
            wheatherData.WheatherDataChanged += statisticsDisplay.Update;


            wheatherData.Humidity = 11.11f;
            wheatherData.Pressure = 11.22f;


            wheatherData.Pressure = 11.22f;

            wheatherData.Pressure = 22.22f;
            wheatherData.Temperature = -115.25f;
        }
    }
}
