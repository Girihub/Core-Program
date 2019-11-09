//----------------------------------------------------
// <copyright file="ObserverTest.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ObserverTest as class
    /// </summary>
    public class ObserverTest
    {
        /// <summary>
        /// ObserverFunction as a function
        /// </summary>
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
