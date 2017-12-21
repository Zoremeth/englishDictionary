using System;
using System.IO;

namespace CodingProject
{
    class DictionaryStorage
    {
        BilingualDictionary dict = new BilingualDictionary();
        string currentDir = Directory.GetCurrentDirectory();
        public void loadData()
        {
           //Check if files exist.
           if(!System.IO.File.Exists(@currentDir + "\\word.txt"))
                {
                    System.IO.File.Create(@currentDir + "\\word.txt");
                    if(!System.IO.File.Exists(@currentDir + "\\definition.txt"))
                    {
                        System.IO.File.Create(@currentDir + "\\definition.txt");
                    }
                }

                else {
                // This will not work. It will say that the key already exists for some reason. 
                foreach(string word in System.IO.File.ReadAllLines(@currentDir + "\\word.txt"))
                {
                    foreach(string definition in System.IO.File.ReadAllLines(@currentDir + "\\definition.txt"))
                    {
                        dict.AddEntry(word, definition);
                    }
                }
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
}   



