using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

    internal interface SocketAdapter
    {
        Volt Get120Volt();
        Volt Get12Volt();
        Volt Get3Volt();
    }
}
