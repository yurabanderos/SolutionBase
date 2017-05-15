using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 34;
            Console.WriteLine("  " + address.Index + address.House + address.Country + address.City + address.Appartment);
            Console.ReadKey();
        }
    }
}