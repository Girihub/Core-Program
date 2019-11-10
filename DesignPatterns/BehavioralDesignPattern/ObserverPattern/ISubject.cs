//----------------------------------------------------
// <copyright file="ISubject.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ISubject as an interface having functions declared in it
    /// </summary>
    internal interface ISubject
    {
        /// <summary>
        /// Function to Add observer
        /// </summary>
        /// <param name="observer">observer as a parameter</param>
        void Add(IObserver observer);

        /// <summary>
        /// Function to Remove observer
        /// </summary>
        /// <param name="observer">observer as a parameter</param>
        void Remove(IObserver observer);

        /// <summary>
        /// Function to Notify observer
        /// </summary>
        void Notify();
    }
}
