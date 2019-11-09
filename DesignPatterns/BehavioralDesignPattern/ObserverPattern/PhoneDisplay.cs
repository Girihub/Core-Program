//----------------------------------------------------
// <copyright file="PhoneDisplay.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class PhoneDisplay implements IObserver
    /// </summary>
    public class PhoneDisplay : IObserver
    {
        /// <summary>
        /// private field wheatherStation
        /// </summary>
        private WheatherStation wheatherStation;

        /// <summary>
        /// Function to display data in phone
        /// </summary>
        /// <param name="wheatherStation">wheatherStation as a parameter</param>
        public PhoneDisplay(WheatherStation wheatherStation)
        {
            this.wheatherStation = wheatherStation;
        }

        /// <summary>
        /// Function to update data in phone
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Phone Displays the temperature as " + this.wheatherStation.GetTemperature());
        }
    }
}
