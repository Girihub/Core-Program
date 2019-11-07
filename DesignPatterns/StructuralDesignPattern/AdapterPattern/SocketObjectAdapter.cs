using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    class SocketObjectAdapter:SocketAdapter
    {
        private Socket socket = new Socket();

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }

        public Volt Get120Volt()
        {
            return socket.GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = socket.GetVolt();
            return ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = socket.GetVolt();
            return ConvertVolt(v, 40);
        }
    }
}
