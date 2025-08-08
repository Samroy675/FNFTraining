//9. Write a function called "reverseByWords", that takes a sentence (string) as an input, and returns
//another string. The return value must be a sentence in which the words in the original sentence appear in
//reverse order.
//public static string reverseByWords(string sentence)
//{
//    // do stuff here
//    return null;
//}

using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan_J_Project
{
    internal class Assignment9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any sentence of your wish: ");
            string sentence = Console.ReadLine();
            Console.WriteLine();
            string res = reverseByWords(sentence);
            Console.WriteLine(res);
            
        }

        static string reverseByWords(string sentence)
        {
            string[] arr = sentence.Split(' ');
            reverseString(arr);
            return string.Join(" ", arr);
        }

        static void reverseString(string[] str)
        {
            int n = str.Length;
            int p = 0;
            int q = n - 1;
           while(p<q)
            {
                string temp = str[p];
                str[p] = str[q];
                str[q] = temp;
                p++;
                q--;
            }
        }
    }
}
