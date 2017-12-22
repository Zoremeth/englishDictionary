using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingProject
{
    public class BilingualDictionary
    {
        private Dictionary<string, string> dataDictionary = new Dictionary<string, string>();
        public IEnumerable<KeyValuePair<string, string>> Entries => dataDictionary;

        public void AddEntry(string word, string definition)
        {
            dataDictionary.Add(word, definition);
        }

        public bool DeleteEntry(string delKey)
        {
            return dataDictionary.Remove(delKey);
        }

        public void ChangeEntry(string inputKey, string correctedWord, string correctedDefinition)
        {
            if ( correctedDefinition == "")
            {
                Console.WriteLine("Definition can not be empty.");
            }
            else
            {
                if (DeleteEntry(inputKey))
                {
                    if (correctedWord == "")
                    {
                        AddEntry(inputKey, correctedDefinition);
                    }
                    else
                    {
                        AddEntry(correctedWord, correctedDefinition);
                    }
                }
            }
        }
        public string SearchWord(string inputKey)
        {
            dataDictionary.TryGetValue(inputKey, out string definition);
            return definition;
        }

        public void ListAll()
        {
            Console.WriteLine("All entries:");
            foreach (var entry in dataDictionary)
            { 
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
        }
    }
}