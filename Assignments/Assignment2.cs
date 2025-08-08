//2. Write a function that takes an array of numbers and it should display the Odd and Even numbers......

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            arrayOfOddAndEven(numbers);
        }

        static void arrayOfOddAndEven(int[] numbers)
        {
            Console.WriteLine("Odd Numbers are ");
            foreach(int i in numbers)
            {
                if(i%2!=0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Even Numbers are ");
            foreach (int i in numbers)
            {
                if (i%2==0)
                {
                    Console.Write($"{i}  ");
                }
            }
        }
    }
}
