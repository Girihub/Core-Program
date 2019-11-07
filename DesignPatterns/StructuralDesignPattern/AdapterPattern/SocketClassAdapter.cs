using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    class SocketClassAdapter : Socket, SocketAdapter
    {
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
        
        public Volt Get120Volt()
        {   
            return this.GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 40);
        }
    }
}
