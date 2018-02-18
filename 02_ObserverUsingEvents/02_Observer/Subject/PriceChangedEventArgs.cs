using System;

namespace _02_Observer.Subject
{
    class WheatherDataEventArgs : EventArgs
    {
        public IWheatherData CurrentWheatherData { get; set; }

        public WheatherDataEventArgs(IWheatherData newWheatherData)
        {
            CurrentWheatherData = newWheatherData;
        }
    }
}
