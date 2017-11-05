using System;

namespace CodingProject
{
    public class DictionaryInterface
    { 
        BilingualDictionary dict = new BilingualDictionary();
        DictionaryStorage dictStorage = new DictionaryStorage();
        public void Run()
        {
            dictStorage.loadData();
            dict.AddEntry("Hello", "World");
            dict.AddEntry("Henlo", "Wereld");
            Console.WriteLine("-----------------------\nWelcome to the dictionary\nPlease select an option:");
            foreach (var entry in dict.Entries)
            {
                Console.WriteLine("{0}", entry.Key);
            }
            dictStorage.saveData();
        }
    }
}