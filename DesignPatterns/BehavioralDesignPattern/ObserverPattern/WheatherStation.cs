using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    public class WheatherStation : Subject
    {
        private int temperature = 43;
        ArrayList Observers = new ArrayList(); 
        public void Add(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in this.Observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            this.Remove(observer);
        }

        public int GetTemperature()
        {
            return this.temperature;
        }
    }
}
