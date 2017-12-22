using System;
using System.IO;

namespace CodingProject
{
    public class DictionaryInterface
    {
        BilingualDictionary dict = new BilingualDictionary ();
        DictionaryStorage dictStorage = new DictionaryStorage ();
        string currentDir = Directory.GetCurrentDirectory ();
        public void Run ()
        {
            var dict = dictStorage.loadData (Path.Combine (Directory.GetCurrentDirectory (), "entries.txt"));
            foreach (var entry in dict.Entries)
            {
                Console.WriteLine ("{0}, {1}", entry.Key, entry.Value);
            }
            dict.AddEntry ("Test", "Hi");
            dictStorage.saveData (Path.Combine (Directory.GetCurrentDirectory (), "entries.txt"));

            //Interface stuff
            //Console.WriteLine("-----------------------\nWelcome to the dictionary\nPlease select an option:");
        }
    }
}