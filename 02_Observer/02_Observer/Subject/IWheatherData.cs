namespace _02_Observer.Subject
{
    interface IWheatherData
    {
        float Temperature { get; }
        float Humidity { get; }
        float Pressure { get; }
    }
}