// 1. Word frequency counter allows you to count the frequency usage of each word in
//your text. Write a program to find the word and its frequency.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonForCSharp
{
    internal class Question1
    {
        static void wordFrequencyCounter(string sentence)
        {
            try {
                Dictionary<string, int> counter = new Dictionary<string, int>();
                string[] words = sentence.ToLower().Split(new char[] { ' ', '.', '?', ',', '!', '@', '#' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (counter.ContainsKey(word)) counter[word]++;
                    else counter[word] = 1;
                }

                Console.WriteLine("\n\n**************Descending Order of Frequency of Words**************\n\n");
                var sortedWords = counter.OrderByDescending(pair => pair.Value).ThenByDescending(pair => pair.Key);
                foreach (var pair in sortedWords)
                {
                    Console.WriteLine($"{pair.Key} {pair.Value}");
                }
                Console.WriteLine();
            } catch (Exception e)
            {
                Console.WriteLine($"0");
            } finally {
                Console.WriteLine("Program Exited Succesfully!!!");
            }
            


        }
        static void Main(string[] args)
        {
            Console.WriteLine("****************User Inputs************************");
            Console.Write("\nEnter some dummy sentences: ");
            string sentence = Console.ReadLine();
            wordFrequencyCounter(sentence);
        }
    }
}






