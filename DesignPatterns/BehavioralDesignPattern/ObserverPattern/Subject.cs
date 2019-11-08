using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    interface Subject
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
