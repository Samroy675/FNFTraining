//7. Implement the body for the following function:
//static boolean isPrimeNumber(int num)
//{
//    // do stuff here
//    return true;
//}
//The function should check and return true only if the number passed as argument is a prime number.
//Write a C# program to call the above function multiple times with different values.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Roshan_J_Project
{
    internal class Assignment7
    {
        static void Main(string[] args)
        {
        Back:
            try
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                bool res = isPrimeNumber(num);
                if (res == true) Console.WriteLine($"{num} is a Prime Number.");
                else Console.WriteLine($"{num} is not a Prime Number.");
                goto Back;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid Input");
            } 
        }


        static bool isPrimeNumber(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
