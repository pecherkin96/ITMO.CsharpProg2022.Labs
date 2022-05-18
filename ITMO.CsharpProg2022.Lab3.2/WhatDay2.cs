﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CsharpProg2022.Lab3._2
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
            try
            {
                Console.WriteLine("Введите номер дня в промежутке от 1 до 365.");
                string line = Console.ReadLine();
                ushort dayNum = ushort.Parse(line);
                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException("Day out of Range");
                }
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
            catch(Exception caught)
            {
             Console.WriteLine(caught);
            }
        }
    }
}
