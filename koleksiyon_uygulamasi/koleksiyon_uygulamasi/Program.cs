using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        
        SortedDictionary<string, SortedDictionary<string, string>> phoneBook = new();

        
        string[] lines = File.ReadAllLines("telefon_rehberi.txt");

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string name = parts[0].Trim();
                string city = parts[1].Trim();
                string phone = parts[2].Trim();

                
                if (!phoneBook.ContainsKey(city))
                {
                    phoneBook[city] = new SortedDictionary<string, string>();
                }

                
                phoneBook[city][name] = phone;
            }
        }

        
        foreach (var city in phoneBook)
        {
            Console.WriteLine($"{city.Key} :");
            foreach (var person in city.Value)
            {
                Console.WriteLine($"  {person.Key} - {person.Value}");
            }
        }
    }
}
