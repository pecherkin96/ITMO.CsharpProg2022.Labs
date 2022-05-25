using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab4._1
{
    class Test
    {
        public static void Main()
        {
            int x;
            int y;
            int greater;

            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());

            greater = Utlis.Greater(x, y);
            Console.WriteLine("Значение greater:{0}", greater);

        }
    }
}
