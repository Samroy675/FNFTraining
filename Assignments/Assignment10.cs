using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project

{
    internal class Assignment10
    {
        static string[] ones = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
            "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen"};
        static string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 to 99,99,99,999: ");
            long num = long.Parse(Console.ReadLine());
            string res = numberToWords(num);
            Console.WriteLine($"{num} in words is {res} only");
        }
        static string convertToWords(int num)
        {
            if (num < 20) return ones[num];
            else return tens[num / 10] + (num % 10 > 0 ? " " + ones[num % 10] : "");
        }

        static string numberToWords(long num)
        {
            if (num < 1 || num > 999999999)
            {
                Console.WriteLine("Sorry, Your value is out of range....");
            }
            string result = "";
            if(num / 10000000 > 0)
            {
                result += convertToWords((int)num / 10000000) + " crore ";
                num %= 10000000;
            }
            if (num / 100000 > 0)
            {
                result += convertToWords((int)num / 100000) + " lakh ";
                num %= 100000;
            }
            if (num / 1000 > 0)
            {
                result += convertToWords((int)num / 1000) + " thousand ";
                num %= 1000;
            }
            if (num / 100 > 0)
            {
                result += convertToWords((int)num / 100) + " hundred ";
                num %= 100;
            }
            if(num > 0)
            {
                if(result != "")
                {
                    result += "and ";
                }
                result += convertToWords((int)num);
            }
            return result; 
        }
    }
}

