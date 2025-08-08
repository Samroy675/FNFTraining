//1. Write a program that displays the range of all the floating and integral types of.NET CTS.....

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            floatingPointTypes();
            Console.WriteLine();
            integralTypes();
        }

        static void floatingPointTypes()
        {
            Console.WriteLine("******Floating-Point Types******");
            Console.WriteLine();
            Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");
        }

        static void integralTypes()
        {
            Console.WriteLine("******Integral Types******");
            Console.WriteLine();
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");
            Console.WriteLine($"char: {(int)char.MinValue} to {(int)char.MaxValue}");
        }
    }
}

