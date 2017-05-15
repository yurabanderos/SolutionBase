using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ToUsd(double uarSum)
        {
            Console.WriteLine(uarSum / usd);
        }

        public void FromUsd(double usdSum)
        {
            Console.WriteLine(usdSum * usd);
        }

        public void ToEur(double uarSum)
        {
            Console.WriteLine(uarSum / eur);
        }

        public void FromEur(double uarSum)
        {
            Console.WriteLine(uarSum * usd);
        }

        public void ToRub(double uarSum)
        {
            Console.WriteLine(uarSum / rub);
        }

        public void FromRub(double uarSum)
        {
            Console.WriteLine(uarSum * usd);
        }
    }
}
