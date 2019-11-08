using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    public class ProxyInternet:Internet
    {
        private Internet internet = new RealInternet();
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
