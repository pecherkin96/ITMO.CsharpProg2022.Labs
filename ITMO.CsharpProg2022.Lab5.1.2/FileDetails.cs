using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.CsharpProg2022.Lab5._1._2
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            try
            { 
            string fileName = args [0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();

            }
            foreach (char ch in contents)
            {
                Console.Write(ch);

            }
            reader.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
