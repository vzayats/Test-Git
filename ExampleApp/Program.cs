using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Information about user
            User user = new User();
            user.GetInformation();
            user.GetDate();

            Console.WriteLine();

            //Information about network
            NetworkInfo network = new NetworkInfo();
            network.GetIPAddress();

            Console.ReadLine();
        }
    }
}
