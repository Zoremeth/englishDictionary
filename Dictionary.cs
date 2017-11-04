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
        public void List(int ListType)
        {
            switch (ListType)
            {
                case 1:
                    //Print Keys & Values
                    foreach (var data in dataDictionary)
                    {
                        Console.WriteLine("{0}, {1}", data.Key, data.Value);
                    }
                    break;

                case 2:
                    //Print Keys
                    foreach (var data in dataDictionary)
                    {
                        Console.WriteLine("{0}", data.Key);
                    }
                    break;
                
                case 3:
                    //Print Values
                    foreach (var data in dataDictionary)
                    {
                        Console.WriteLine("{0}", data.Value);
                    }
                    break;
                
                default:
                    //Do nothing
                    break;
            }
        }
        
    }
}