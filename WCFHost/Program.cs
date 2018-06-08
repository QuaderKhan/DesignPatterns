using MyWCFServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost svchost = new ServiceHost(typeof(MyWCFService)))
            {
                svchost.Open();
                Console.WriteLine("Service host is now open");
                using (ServiceHost host = new ServiceHost(typeof(DataService)))
                {
                    host.Open();
                    Console.WriteLine("Data Service host is now open");
                    using(ServiceHost transHost=new ServiceHost(typeof(TransactionWCFService)))
                    {
                        transHost.Open();
                        Console.WriteLine("Transaction host is now open");
                        using (ServiceHost sesssionHost=new ServiceHost(typeof(MyWCFServices.SessionHandlingService)))
                        {
                            sesssionHost.Open();
                            Console.WriteLine("Session host is now open");
                            Console.ReadLine();

                        }
                       
                    }
                }
            }

           
        }
    }
}
