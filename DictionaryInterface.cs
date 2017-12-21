using System;
using System.IO;

namespace CodingProject
{
    public class DictionaryInterface
    { 
        BilingualDictionary dict = new BilingualDictionary();
        DictionaryStorage dictStorage = new DictionaryStorage();
        string currentDir = Directory.GetCurrentDirectory();
        public void Run()
        {
            //Load in data
            var dict = dictStorage.loadData(@currentDir + "\\word.txt");
            
            dict.AddEntry("Hello", "World");
            
            //Check what is saved in the dictionary
            foreach (var entry in dict.Entries)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }

            //Save data 
            //dictStorage.saveData();

            //Interface stuff
            //Console.WriteLine("-----------------------\nWelcome to the dictionary\nPlease select an option:");
        }
    }
}