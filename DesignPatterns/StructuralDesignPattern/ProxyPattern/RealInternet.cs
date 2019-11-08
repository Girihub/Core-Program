using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    public class RealInternet : Internet
    {
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to " + serverHost);
        }
    }
}
