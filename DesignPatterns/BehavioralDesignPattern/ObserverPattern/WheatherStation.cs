//----------------------------------------------------
// <copyright file="WheatherStation.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class implements interface ISubject
    /// </summary>
    public class WheatherStation : ISubject
    {        
        /// <summary>
        /// create new list for observers
        /// </summary>
        private ArrayList observers = new ArrayList();

        /// <summary>
        /// private field temperature
        /// </summary>
        private int temperature = 43;

        /// <summary>
        /// Function to add observer
        /// </summary>
        /// <param name="observer">observer as a parameter</param>
        public void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Function to notify update to observer
        /// </summary>
        public void Notify()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update();
            }
        }

        /// <summary>
        /// Function to remove observer
        /// </summary>
        /// <param name="observer">observer as a parameter</param>
        public void Remove(IObserver observer)
        {
            this.Remove(observer);
        }

        /// <summary>
        /// Function to get temperature
        /// </summary>
        /// <returns>returns temperature value</returns>
        public int GetTemperature()
        {
            return this.temperature;
        }
    }
}
