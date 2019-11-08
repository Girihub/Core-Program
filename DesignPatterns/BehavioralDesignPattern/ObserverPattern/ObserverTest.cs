using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    public class ObserverTest
    {
        public void ObserverFunction()
        {
            WheatherStation station = new WheatherStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay(station);
            ComputerDisplay computerDisplay = new ComputerDisplay(station);
            phoneDisplay.Update();
            computerDisplay.Update();
        }
    }
}
