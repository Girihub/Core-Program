using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPattern.MediatorPattern
{
    public class MediatorPattern
    {
        public void MediatorFunction()
        {
            User giri = new User("Giri");
            User chets = new User("Chets");
            giri.SendMessage("Aur bhai kya haal hai?");
            chets.SendMessage("Bas badhiya yaar");
        }          
    }
}
