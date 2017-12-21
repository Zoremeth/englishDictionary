using System;
using System.IO;

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
            else {
                string[] entries = System.IO.File.ReadAllLines(dataDictionary);
                foreach (string entry in entries)
                {
                    string[] splitEntry = entry.Split(new Char[] { '|' });
                    dict.AddEntry(splitEntry[0], splitEntry[1]);
                }
            }
            return dict;
        }
    }   
        //First focusing on the loading system.
        // public void saveData()
        // {
        //     foreach(var entry in dict.Entries)
        //     {
        //         //Check if the key exists not to make duplicates, if not run command
        //         if(!System.IO.File.ReadAllText(@currentDir + "\\word.txt").Contains(entry.Key))
        //         {
        //             System.IO.File.AppendAllText(@currentDir + "\\word.txt", entry.Key);
        //         }

        //         if(!System.IO.File.ReadAllText(@currentDir + "\\definition.txt").Contains(entry.Value))
        //         {
        //             System.IO.File.AppendAllText(@currentDir + "\\definition.txt", entry.Value);
        //         }
        //     }
        // }  
}



