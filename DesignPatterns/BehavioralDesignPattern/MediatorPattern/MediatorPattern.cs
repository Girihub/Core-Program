//----------------------------------------------------
// <copyright file="MediatorPattern.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.MediatorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// MediatorPattern class to implement Mediator Pattern
    /// </summary>
    public class MediatorPattern
    {
        /// <summary>
        /// MediatorFunction as a function
        /// </summary>
        public void MediatorFunction()
        {
            User giri = new User("Giri");
            User chets = new User("Chets");
            giri.SendMessage("Aur bhai kya haal hai?");
            chets.SendMessage("Bas badhiya yaar");
        }          
    }
}
