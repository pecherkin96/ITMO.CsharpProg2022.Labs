using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab3._1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class WhatDay
    {
        static System.Collections.ICollection DaysInMonths
            = new byte[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня в промежутке от 1 до 365.");
            string line = Console.ReadLine();
            ushort dayNum = ushort.Parse(line);
            byte monthNum = 0;
            foreach (byte daysInMonth in DaysInMonths)
            {
                if (dayNum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    dayNum -= daysInMonth;
                    monthNum++;
                }
            }
         MonthName temp = (MonthName)monthNum;
         string monthName = temp.ToString();
         Console.WriteLine("{0} {1}", dayNum, monthName);            
        }
    }
}