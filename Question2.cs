// 2. Librarian has a list of books and their authors as a text. You need to write a program
// to assist him. Write a method that prints the output as the book titles and is sorted based
// on the alphabetical order of their author names and book titles.
//The Function signature:
//List<String> SortTitles(List<String>) { }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonForCSharp
{
    internal class Question2
    {
        static List<String> SortTitles(List<String> titles) {

            List<string> list = new List<string>();

            foreach (string title in titles)
            {
                int index = title.IndexOf("by",StringComparison.OrdinalIgnoreCase); 
                if(index != -1){
                    string authorName = title.Substring(0,index);
                    string cleanedTitle = authorName.Replace("\"",string.Empty); 
                    list.Add(cleanedTitle);
                }
                else
                {
                    string cleanedTitle = title.Replace("\"", string.Empty);
                    list.Add(cleanedTitle);
                }
            }
            return list.OrderByDescending(t => t).ToList();
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("****************User Inputs************************");
            Console.Write("\nEnter the number of book entries: ");
            int size = int.Parse(Console.ReadLine());
            string[] strings = new string[size];
            Console.Write("\nEnter the set of Book Titles and Authors: \n");
            for (int i = 0; i < size; i++)
            {
                strings[i] = Console.ReadLine();
            }
            foreach (string s in strings)
            {
                list.Add(s);
            }

            Console.WriteLine("\n****************Sorted Titles********************");
            foreach (string title in SortTitles(list))
            {
                Console.WriteLine(title);
            }
        }
    }
}
