//----------------------------------------------------
// <copyright file="ChatRoom.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.BehavioralDesignPattern.MediatorPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for Mediator Pattern
    /// </summary>
    public class ChatRoom
    {
        /// <summary>
        /// Function to show the message sent by user
        /// </summary>
        /// <param name="user">user class as parameter</param>
        /// <param name="message">message, to be passed, as a parameter</param>
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(user.GetName() + ": " + message);
        }
    }
}
