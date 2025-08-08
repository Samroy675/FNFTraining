//8. Implement the C# function listed below:
//public static void printCalendar(int month, int year)
//{
//    /// do stuff here
//}
//The function should accept month and year and print the calendar for the same. If inputs are invalid, appropriate error message/s should be printed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the month: ");
           int mon = int.Parse(Console.ReadLine());
            Console.Write("Enter the year: ");
            int yr = int.Parse(Console.ReadLine());
            printCalendar(mon, yr);
        }

        static void printCalendar(int month, int year)
        {
            string[] monthNames = {"","January", "February", "March", "April", "May", "June", "July", "August", "September",
                                  "October", "November", "December"};

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && isLeapYear(year)) daysInMonth[2] = 29;

           int startDay = getStartDate(month, year);

            Console.WriteLine($"   {monthNames[month]} {year}");
            Console.WriteLine("Su Mo Tu We Th Fr Sa");
            for (int i = 0; i < startDay; i++) Console.Write("   ");

            for (int day = 1; day <= daysInMonth[month]; day++) {
                Console.Write($"{day,2} ");
                startDay++;

                if (startDay % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
           Console.WriteLine() ;    
        }

        static int getStartDate(int mon, int yr)  //Zellurer's Congruence Algo
        {
            if(mon == 1 || mon == 2)
            {
                mon += 12;
                yr --;
            }
            int p = 1;
            int m = mon;
            int q = yr % 100;
            int r = yr / 100;

            int z = (p + (13 * (m + 1)) / 5 + q + q/4 + r/4 + (5 * r)) % 7;

            return (z + 6) % 7;
        }

        static bool isLeapYear(int num)
        {
            if (num % 4 == 0 && (num % 100 != 0 || num % 400 == 0)) return true;
            return false;
        }
    }
}
