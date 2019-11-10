//----------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ProxyInternet:IInternet
    {
        private IInternet internet = new RealInternet();
        ArrayList bannedSites = new ArrayList();
        public ProxyInternet()
        {
            bannedSites.Add("abc.com");
            bannedSites.Add("xyz.com");
            bannedSites.Add("yyy.com");
        }

        public void ConnectTo(string serverHost)
        {
            if (bannedSites.Contains(serverHost))
            {
                throw new Exception("Site is Banned");
            }
            internet.ConnectTo(serverHost);
        }
    }
}
