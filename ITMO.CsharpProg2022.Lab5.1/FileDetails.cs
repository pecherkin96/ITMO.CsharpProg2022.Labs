using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.CsharpProg2022.Lab5._1
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string arg in args)
                Console.WriteLine(arg);
        }
    }
}
