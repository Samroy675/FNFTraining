//6. Implement the body for the following function:
//static boolean isValidDate(int year, int month, int day)
//{
//    return false;
//}
//The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false.
//For example,
//year = 2018, month = 13, day = 1 is an invalid date as the possible values for month is 1 to 12.
//year=2018, month = 2, day = 29 is an invalid date as the maximum days in February is 28 in the year 2018
//year=2016, month = 2, day = 29 is a valid date.
//Write a C# program to call the above function multiple times with different values.

    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidDate(2018, 13, 1));   
            Console.WriteLine(IsValidDate(2018, 2, 29));   
            Console.WriteLine(IsValidDate(2016, 2, 29));   
            Console.WriteLine(IsValidDate(2020, 4, 31));   
            Console.WriteLine(IsValidDate(2022, 12, 25));  
        }


        static bool IsValidDate(int year, int month, int day)
        {
            if (month < 1 || month > 12) return false;
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (IsLeapYear(year)) daysInMonth[1] = 29;
            if (day < 1 || day > daysInMonth[month - 1]) return false;
            return true;
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

    }


}

