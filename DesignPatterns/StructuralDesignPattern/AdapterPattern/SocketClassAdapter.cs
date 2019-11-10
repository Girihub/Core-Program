//----------------------------------------------------
// <copyright file="SocketClassAdapter.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.AdapterPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class SocketClassAdapter extends Socket and implements ISocketAdapter
    /// </summary>
    public class SocketClassAdapter : Socket, ISocketAdapter
    {
        /// <summary>
        /// Function to convert volt
        /// </summary>
        /// <param name="v">volt v as a parameter</param>
        /// <param name="i">i as a parameter</param>
        /// <returns>returns new instance of Volt with converting Volt</returns>
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
        
        /// <summary>
        /// Function to convert volt into 120
        /// </summary>
        /// <returns>returns 120 volt</returns>
        public Volt Get120Volt()
        {   
            return this.GetVolt();
        }

        /// <summary>
        /// Function to convert volt into 12
        /// </summary>
        /// <returns>returns 12 volt</returns>
        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 10);
        }

        /// <summary>
        /// Function to convert volt into 3
        /// </summary>
        /// <returns>returns 3 volt</returns>
        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 40);
        }
    }
}
