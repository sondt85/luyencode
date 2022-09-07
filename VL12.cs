using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL12
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            if (n == 0) Console.Write("INF");
            else
            {
                for (int i = n; i > 0; i--)
                    if (n % i == 0)
                        Console.Write("{0} ", i);
            }
            Console.ReadLine();

        }
    }
}
