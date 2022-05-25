using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab4._2
{
    class Test
    {
        public static void Main()
        {
            int x;
            int y;

            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Before swap: " + x + "," + y);
            Utlis.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

        }
    }
}
