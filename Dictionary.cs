using System;
using System.Collections.Generic;

namespace BilingualDictionary
{
    public class BilingualDictionary
    {
        private Dictionary <string, string> dataDictionary = new Dictionary <string, string> (); 
        static void main(){}
        public void AddEntry()
        {
            Console.WriteLine("Add entry");
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            Console.WriteLine("Enter definition:");
            string definition = Console.ReadLine();
            Console.WriteLine("Adding entry: {0}, {1}", word, definition);
            dataDictionary.Add(word, definition);
        }

        public void DeleteEntry()
        {
            Console.WriteLine("What entry would you like to delete?:");
            ListKeys();
            string delKey = Console.ReadLine();
            Console.WriteLine("Deleting entry: {0}", delKey);
            if (dataDictionary.ContainsKey(delKey))
            {
                dataDictionary.Remove(delKey);
            } else { Console.WriteLine("Could not find entry."); } 
        }

        public void ChangeEntry()
        {
            Console.WriteLine("What value would you like to change?");
            ListKeys();
            string input = Console.ReadLine();
            if(dataDictionary.ContainsKey(input)){
                Console.WriteLine("What would you like to change it to?");
                string correctedWord = Console.ReadLine();
                Console.WriteLine("What would you like to change the definition to?");
                string correctedDefinition = Console.ReadLine();
                dataDictionary.Remove(input);
                dataDictionary.Add(correctedWord, correctedDefinition);
             } else { Console.WriteLine("Entry does not exist"); }
        }
        public void ListAll()
        {
            Console.WriteLine("Currently stored entries:");
            foreach (var data in dataDictionary)
            {
                Console.WriteLine("{0}, {1}", data.Key, data.Value);
            }
        }

        public void ListKeys()
        {
            foreach (var data in dataDictionary)
            {
                Console.WriteLine("{0}", data.Key); 
            }
        }
        public void ListValues()
        {
            foreach (var data in dataDictionary)
            {
                Console.WriteLine("{0}", data.Value); 
            }
        }
    }
}