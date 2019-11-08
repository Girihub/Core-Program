using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralDesignPattern.ProxyPattern
{
    public class ProxyTest
    {
        public void ProxyTestFunction()
        {
            try
            {
                Internet internet = new ProxyInternet();
                internet.ConnectTo("bridgelabz.com");
                internet.ConnectTo("yyy.com");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
