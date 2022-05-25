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

        static System.Collections.ICollection DaysInLeapMonths
            = new byte[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите год:");
                string line = Console.ReadLine();
                ushort yearNum = ushort.Parse(line);

                bool isLeapYear = (yearNum % 4 == 0)
                    && (yearNum % 100 != 0
                    || yearNum % 400 == 0);

                int maxDayNum = isLeapYear ? 366 : 365;

                Console.WriteLine("Введите номер дня в промежутке от 1 до {0}:", maxDayNum);
                line = Console.ReadLine();
                ushort dayNum = ushort.Parse(line);
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of Range");
                }

                byte monthNum = 0;

                if (isLeapYear)
                {
                    foreach (byte daysInMonth in DaysInLeapMonths)
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
                }
                else
                {
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
