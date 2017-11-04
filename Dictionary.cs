using System;
using System.Collections.Generic;

namespace CodingProject
{
    public class BilingualDictionary
    {
        private Dictionary <string, string> dataDictionary = new Dictionary <string, string> (); 
        public void AddEntry(string word, string definition)
        {
            dataDictionary.Add(word, definition);
        }

        bool DeleteEntry(string delKey)
        {
            bool deleted = false;
            if (dataDictionary.ContainsKey(delKey))
            {
                dataDictionary.Remove(delKey);
                return deleted = true;
            } else { 
                return deleted = false;
            } 
        }

        public void ChangeEntry(string inputKey, string correctedWord, string correctedDefinition)
        {
            if ( DeleteEntry(inputKey) == true ){
                AddEntry(correctedWord, correctedDefinition);
            }
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