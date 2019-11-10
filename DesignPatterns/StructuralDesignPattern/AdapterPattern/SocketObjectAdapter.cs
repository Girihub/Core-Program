//----------------------------------------------------
// <copyright file="SocketObjectAdapter.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class SocketObjectAdapter implements interface ISocketAdapter
    /// </summary>
    class SocketObjectAdapter : ISocketAdapter
    {
        /// <summary>
        /// private socket instance
        /// </summary>
        private Socket socket = new Socket();

        /// <summary>
        /// Function to convert volt
        /// </summary>
        /// <param name="v">volt v as a parameter</param>
        /// <param name="i">i as a parameter as divisor</param>
        /// <returns>returns new instance of volt</returns>
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }

        /// <summary>
        /// Function to get 120 volt
        /// </summary>
        /// <returns>returns new volt</returns>
        public Volt Get120Volt()
        {
            return socket.GetVolt();
        }

        /// <summary>
        /// Function to get 12 volt
        /// </summary>
        /// <returns>returns new volt</returns>
        public Volt Get12Volt()
        {
            Volt v = socket.GetVolt();
            return ConvertVolt(v, 10);
        }

        /// <summary>
        /// Function to get 3 volt
        /// </summary>
        /// <returns>returns new volt</returns>
        public Volt Get3Volt()
        {
            Volt v = socket.GetVolt();
            return ConvertVolt(v, 40);
        }
    }
}
