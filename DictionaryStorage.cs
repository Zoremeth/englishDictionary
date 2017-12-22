using System;
using System.IO;
using System.Linq;

namespace CodingProject
{
    class DictionaryStorage
    {

        public BilingualDictionary loadData(string dataDictionary)
        {
            var dict = new BilingualDictionary();
            if (System.IO.File.Exists(dataDictionary))
            {
                string[] entries = System.IO.File.ReadAllLines(dataDictionary);
                foreach (string entry in entries)
                {
                    string[] splitEntry = entry.Split(new Char[] { '|' });
                    dict.AddEntry(splitEntry[0], splitEntry[1]);
                }
                System.IO.File.Delete(dataDictionary + ".bak");
            }
            else
            {
                Console.WriteLine("No pre-existing dictionary found.");
            }
            return dict;
        }
        public void saveData(BilingualDictionary dict, string dataDictionary)
        {
            bool backupData()
            {
                System.IO.File.Move(dataDictionary, dataDictionary + ".bak");
                return (System.IO.File.Exists(dataDictionary));
            }
            bool backupSuccess = backupData();
            var mergedEntries = dict.Entries.Select(entry => entry.Key + "|" + entry.Value);
            if (backupSuccess == false)
            {
                foreach (var entry in mergedEntries)
                {
                    System.IO.File.WriteAllLines(dataDictionary, mergedEntries);
                }
            }
            else
            {
                System.IO.File.Move(dataDictionary + ".bak", dataDictionary);
                Console.WriteLine("Saving failed.");
            }
        }
    }
}