﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day7_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to treat the input as case-sensitive? (y/n)");
            string caseSensitiveInput = Console.ReadLine();
            bool caseSensitive = caseSensitiveInput.ToLower() == "y";

            Console.WriteLine("Do you want to use the default input? (y/n)");
            string defaultInput = Console.ReadLine();
            string sentence;
            if (defaultInput.ToLower() == "y")
                sentence = "To be or not to be, Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            else
            {
                Console.WriteLine("Enter your input:");
                sentence = Console.ReadLine();
            }

            //uc 1&2
            char[] delimiters = new char[] { ' ', '.', ',', ';', ':', '!', '?' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            MyHashTable<string, int> hashTable = new MyHashTable<string, int>(words.Length);
            foreach (string word in words)
            {
                string key;

                if (caseSensitive)
                    key = word;
                else
                    key = word.ToLower();

                int value = hashTable.Get(key);

                if (value == 0)
                    value = 1;
                else
                    value += 1;

                hashTable.Add(key, value);
            }

            hashTable.Display();

            //uc 3
            hashTable.Remove("avoidable");
            Console.WriteLine();
            hashTable.Display();

            Console.ReadLine();
        }
    }
}
