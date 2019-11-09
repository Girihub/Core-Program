//----------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IObserver as a interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Function to update data to observer
        /// </summary>
        void Update();
    }
}
