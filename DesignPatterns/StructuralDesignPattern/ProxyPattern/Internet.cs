//----------------------------------------------------
// <copyright file="Internet.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// IInternet as an interface
    /// </summary>
    internal interface IInternet
    {
        /// <summary>
        /// Function ConnectTo for class which implement this
        /// </summary>
        /// <param name="serverHost">serverHost as a parameter</param>
        void ConnectTo(string serverHost);
    }
}
