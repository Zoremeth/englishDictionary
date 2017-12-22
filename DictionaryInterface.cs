using System;
using System.IO;

namespace CodingProject
{
    public class DictionaryInterface
    {
        DictionaryStorage dictStorage = new DictionaryStorage();
        public void Run()
        {
            var dict = dictStorage.loadData(Path.Combine(Directory.GetCurrentDirectory(), "entries.txt"));
            foreach (var entry in dict.Entries)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            dictStorage.saveData(dict, Path.Combine(Directory.GetCurrentDirectory(), "entries.txt"));

            //Interface stuff
            //Console.WriteLine("-----------------------\nWelcome to the dictionary\nPlease select an option:");
        }
    }
}