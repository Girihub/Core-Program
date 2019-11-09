using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine(user.GetName() + ": " + message);
        }
    }
}
