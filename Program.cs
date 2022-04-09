using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numberr number = new Numberr();

            Console.WriteLine("Minimum #1; {0}", number.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3, 2, 4));
            Console.WriteLine();//baris kosong
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}