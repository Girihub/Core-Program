using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    public class AdapterPatternTest
    {
        public void AdapterPatternFunction()
        {
            this.ClassAdapterTest();
            this.ObjectAdapterTest();
        }

        private void ObjectAdapterTest()
        {
            SocketAdapter socketAdapter = new SocketClassAdapter();
            Volt v3 = GetVolt(socketAdapter, 3);
            Volt v12 = GetVolt(socketAdapter, 12);
            Volt v120 = GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 volts using Object Adapter is " + v3.GetVolts());
            Console.WriteLine("v12 volts using Object Adapter is " + v12.GetVolts());
            Console.WriteLine("v120 volts using Object Adapter is " + v120.GetVolts());
        }        

        private void ClassAdapterTest()
        {
            SocketAdapter socketAdapter = new SocketObjectAdapter();
            Volt v3 = GetVolt(socketAdapter, 3);
            Volt v12 = GetVolt(socketAdapter, 12);
            Volt v120 = GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 volts using Object Adapter is " + v3.GetVolts());
            Console.WriteLine("v12 volts using Object Adapter is " + v12.GetVolts());
            Console.WriteLine("v120 volts using Object Adapter is " + v120.GetVolts());
        }

        private Volt GetVolt(SocketAdapter socketAdapter, int v)
        {
            switch (v)
            {
                case 3:
                    return socketAdapter.Get3Volt();

                case 12:
                    return socketAdapter.Get12Volt();

                case 120:
                    return socketAdapter.Get120Volt();

                default:
                    return socketAdapter.Get120Volt();
            }
        }
    }
}
