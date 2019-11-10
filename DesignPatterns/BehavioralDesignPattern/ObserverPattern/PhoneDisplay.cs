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
        /// private field weatherStation
        /// </summary>
        private WheatherStation wheatherStation;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneDisplay"/> class.
        /// </summary>
        /// <param name="weatherStation">weatherStation as a parameter</param>
        public PhoneDisplay(WheatherStation weatherStation)
        {
            this.wheatherStation = weatherStation;
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
