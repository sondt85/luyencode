using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL01
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            for (int i = a; i <= b; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.ReadLine();
        }
    }
}
