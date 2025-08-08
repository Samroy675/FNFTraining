//3. Write a Math Calc Program that allows Users to enter the values and operation and the Program should display
// the result based on the operator the user has typed. It should be in a loop until the user specifies to close it...


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
        Back:
            Console.Write("Wanna try Math Calculator Operations(y/n): ");
            string ans = Console.ReadLine();
            if(ans == "y" || ans == "Y")
            {
                CalcInputs();
                goto Back;
            }else if(ans == "n" || ans == "N")
            {
                Console.WriteLine("Ok, No Problem!");
            }else
            {
                Console.WriteLine("Sorry, Invalid Input");
            }
        }

        static void CalcInputs()
        {
            Console.Write("Enter the first value: ");
            double val1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            double val2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the Operator(+,-,*,/): ");
            string op = Console.ReadLine();
            double result = CalcOperations(val1, val2, op);
            Console.WriteLine($"The Calculated Result is {result}");
        }

        static double CalcOperations(double val1, double val2, string op)
        {
            switch (op)
            {
                case "+":
                    return val1 + val2;
                case "-":
                    return val1 - val2;
                case "*":
                    return val1 * val2;
                case "/":
                    return val1 / val2;
                default: return 0;
            }
        }
    }
}
