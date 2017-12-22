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
            //Check if files exist.
            if(!System.IO.File.Exists(dataDictionary))
            {
                System.IO.File.Create(dataDictionary);
            }
            else 
            {
                string[] entries = System.IO.File.ReadAllLines(dataDictionary);
                foreach (string entry in entries)
                {
                    string[] splitEntry = entry.Split(new Char[] { '|' });
                    dict.AddEntry(splitEntry[0], splitEntry[1]);
                }
            }
            return dict;
        }  
        // First focusing on the loading system.
        public void saveData(string dataDictionary)
        {
            bool backupData()
            {
                System.IO.File.Move(dataDictionary, dataDictionary + ".bak");
                if(System.IO.File.Exists(dataDictionary))
                {
                    return false; 
                }
                else 
                {
                    System.IO.File.Create(dataDictionary);
                    return true;
                }  
            }
            bool backupSuccess = backupData();
            var dict = new BilingualDictionary();
            //Use IENumerable + Zip function.
            var mergedEntries = dict.Entries.Select(entry => entry.Key + "|" + entry.Value);
            if(backupSuccess == true)
            {
                foreach(var entry in mergedEntries)
                {
                    System.IO.File.AppendAllLines(dataDictionary, mergedEntries);
                }
            }
            else
            {
                Console.WriteLine("Saving failed.");
            }
        } 
    }      
}



