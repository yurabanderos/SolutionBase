using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter con = new Converter(12.42, 345.34, 9000.34);
            con.FromUsd(456);
            con.ToUsd(3);
            con.ToEur(5);
            con.ToRub(10);
            Console.ReadKey();
        }
    }
}
