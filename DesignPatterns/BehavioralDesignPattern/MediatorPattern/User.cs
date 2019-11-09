//----------------------------------------------------
// <copyright file="User.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.MediatorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// User as a Class
    /// </summary>
    public class User
    {
        /// <summary>
        /// initiate name
        /// </summary>
        private string name;

        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="name">name as a parameter</param>
        public User(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Function to return user name
        /// </summary>
        /// <returns>return name in string</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Function to set name
        /// </summary>
        /// <param name="name">name, to be set, as a parameter</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Function to send the message
        /// </summary>
        /// <param name="message">message, to be passed, as a parameter</param>
        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
