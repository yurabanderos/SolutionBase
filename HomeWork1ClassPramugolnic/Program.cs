using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(34.34, 55.3);
            Console.WriteLine("Area: {0}, Perimetr: {1}", rec.Area, rec.Perimetr);
            Console.ReadKey();
        }
    }
}