using System;
using System.Collections.Generic;

namespace CodingProject
{
    public class BilingualDictionary
    {
        private Dictionary <string, string> dataDictionary = new Dictionary <string, string> (); 
        public IEnumerable<KeyValuePair<string, string>> Entries => dataDictionary;
        public IEnumerable<string> Words => dataDictionary.Keys;
        public IEnumerable<string> definition => dataDictionary.Values;

        public void AddEntry(string word, string definition)
        {
            dataDictionary.Add(word, definition);
        }

        bool DeleteEntry(string delKey)
        {
            return dataDictionary.Remove(delKey);
        }

        public void ChangeEntry(string inputKey, string correctedWord, string correctedDefinition)
        {
            if (DeleteEntry(inputKey)){
                if(correctedWord == ""){
                    AddEntry(inputKey, correctedDefinition);
                }else if(correctedDefinition == "")
                {
                    Console.WriteLine("Please fill in a definition");
                }else
                AddEntry(correctedWord, correctedDefinition);
            }
        }
    }
}