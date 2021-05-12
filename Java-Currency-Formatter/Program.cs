using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Currency_Formatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dame un valor");
            double pago = Convert.ToDouble(Console.ReadLine());

            if (pago>0 && pago < (10 ^ 9))
            {
                Console.WriteLine("Us:"+"$"+pago);
                Console.WriteLine("India:"+"Rs."+pago);
                Console.WriteLine("China:"+ "￥"+ pago);
                Console.WriteLine("France:" + pago + "€");
            }
            else
            {
                Console.WriteLine("no se puede dar conversion");
            }
        }
    }
}
