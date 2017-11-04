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
            return dataDictionary.Remove(delKey);
        }

        public void ChangeEntry(string inputKey, string correctedWord, string correctedDefinition)
        {
            if ( DeleteEntry(inputKey) == true ){
                AddEntry(correctedWord, correctedDefinition);
            }
        }

        public enum ListFormat
        {
            All,
            Keys,
            Values,
        }
        public void List(ListFormat format)
        {
            foreach (var entry in dataDictionary)
            {
                switch (format)
                {
                    case ListFormat.All:
                        //Print Keys & Values
                            Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
                        break;

                    case ListFormat.Keys:
                        //Print Keys
                            Console.WriteLine("{0}", entry.Key);
                        break;
                    
                    case ListFormat.Values:
                        //Print Values
                            Console.WriteLine("{0}", entry.Value);
                        break;
                    
                    default:
                        //Do nothing
                        break;
                }
            }
        }
        
    }
}