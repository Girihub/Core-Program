using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    public class ComputerDisplay:IObserver
    {
        private WheatherStation wheatherStation;

        public ComputerDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        public void Update()
        {
            Console.WriteLine("Computer displays temperature as " + this.wheatherStation.GetTemperature());
        }
    }
}
