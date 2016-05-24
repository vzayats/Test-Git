using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ExampleApp
{
    class NetworkInfo
    {
        public void GetIPAddress()
        {
            //Information about host name of the local computer
            string hostName = Dns.GetHostName();
            Console.WriteLine("Host name: {0}", hostName);

            //Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("My IP Address is: {0}", myIP);
            Console.ReadKey();
        }
    }
}
