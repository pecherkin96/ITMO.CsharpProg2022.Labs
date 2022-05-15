using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab1._4
{
    class DevideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Пожалуйства, введите первое целое число.");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Пожалуйста, введите второе целое число.");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("Результат деления {2}. {0} поделив на {1}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("Выдано исключение: {0}", e);
            }
        }
    }
}
