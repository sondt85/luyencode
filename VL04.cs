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
            int n = Convert.ToInt32(s);
            double sum = 0;
            for (int i = 2; i <= n; i++)
                sum = sum + 1/(i*1.0);
           // sum = sum + 2 * n;
            Console.WriteLine(sum.ToString("0.0000"));
            Console.ReadLine();
        }
    }
}
