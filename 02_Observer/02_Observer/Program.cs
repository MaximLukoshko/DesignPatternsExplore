using _02_Observer.Observers;
using _02_Observer.Subject;

namespace _02_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var wheatherData = new WheatherData();

            wheatherData.Temperature = 15.25f;
            wheatherData.Pressure = 25.25f;
            wheatherData.Humidity = 28.11f;

            var conditionDisplay = new CurrentConditionDisplay(wheatherData);
            var statisticsDisplay = new StatisticsDisplay(wheatherData);
            var heatIndexDisplay = new HeatIndexDisplay(wheatherData);

            wheatherData.Humidity = 32.11f;

            wheatherData.RemoveObserver(statisticsDisplay);
            wheatherData.Pressure = 35.99f;
            wheatherData.RegisterObserver(statisticsDisplay);


            wheatherData.Humidity = 11.11f;
            wheatherData.Pressure = 11.22f;


            wheatherData.Pressure = 11.22f;

            wheatherData.Pressure = 22.22f;
            wheatherData.Temperature = -115.25f;
        }
    }
}
