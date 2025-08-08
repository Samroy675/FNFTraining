//4. Write a program that creates an array and displays the contents of the array. The array should be
//created dynamically. It means that the size, type should be set by the user of the Program. Take inputs
//for the values also. Finally it should display the values of the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment4
    {
            static void Main(string[] args)
            {
                ArrayInputs();
            }

            static void ArrayInputs()
            {
                Console.Write("Enter the Size: ");
                int size = int.Parse(Console.ReadLine());
                Console.Write("Enter the DataType of your Array(int,float,char,string): ");
                string dataType = Console.ReadLine().ToLower();
                CustomizedArray(dataType, size);
            }

            static void CustomizedArray(string dataType, int size)
            {
                Console.WriteLine("Enter the array elements: ");
                switch (dataType)
                {
                    case "int":
                        int[] arrInt = new int[size];
                        for (int i = 0; i < size; i++)
                        {
                            arrInt[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Write("The elements entered are: ");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"{arrInt[i]} ");
                        }
                        break;
                    case "float":
                        float[] arrFloat = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            arrFloat[i] = float.Parse(Console.ReadLine());
                        }
                        Console.Write("The elements entered are: ");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"{arrFloat[i]} ");
                        }
                        break;
                    case "char":
                        float[] arrCharacter = new float[size];
                        for (int i = 0; i < size; i++)
                        {
                            arrCharacter[i] = char.Parse(Console.ReadLine());
                        }
                        Console.Write("The elements entered are: ");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"{arrCharacter[i]} ");
                        }
                        break;
                    case "string":
                        string[] arrString = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            arrString[i] = Console.ReadLine();
                        }
                        Console.Write("The elements entered are: ");
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"{arrString[i]} ");
                        }
                        break;
                    default:
                        Console.WriteLine("Unsupported type");
                        break;
                }
            }
        }
    }
