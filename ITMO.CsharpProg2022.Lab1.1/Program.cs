using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab1._1
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Пожалуйста, введи своё имя.");
            myName = Console.ReadLine();
            Console.WriteLine("Привет, {0}", myName);
        }
    }
}
