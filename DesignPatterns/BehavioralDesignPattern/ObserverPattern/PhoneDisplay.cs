using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        private WheatherStation wheatherStation;

        public PhoneDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        public void Update()
        {
            Console.WriteLine("Phone Displays the temperature as " + this.wheatherStation.GetTemperature());
        }
    }
}
