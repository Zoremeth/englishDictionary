using System;

namespace CodingProject
{
    class DictionaryStorage
    {
        BilingualDictionary dict = new BilingualDictionary();
        public void loadData()
        {
            //Sorry for disugstingly long file names!! And nested if statements :p
            if(!System.IO.File.Exists(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\word.txt")){
                System.IO.File.Create(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\word.txt");
                if(!System.IO.File.Exists(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\definition.txt")){
                    System.IO.File.Create(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\definition.txt");
                }
            } else {
                foreach(string word in System.IO.File.ReadAllLines(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\word.txt"))
                {
                    foreach(string definition in System.IO.File.ReadAllLines(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\definition.txt"))
                    {
                        dict.AddEntry(word, definition);
                    }
                }
            }
        }   

        //Need to make a save location, current location is for testing
        public void saveData()
        {
            foreach(var entry in dict.Entries)
            {
                //Check if the key exists not to make duplicates, if not run command
                if(!System.IO.File.ReadAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\word.txt").Contains(entry.Key))
                {
                    System.IO.File.AppendAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\word.txt", entry.Key);
                }

                if(!System.IO.File.ReadAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\definition.txt").Contains(entry.Value))
                {
                    System.IO.File.AppendAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\definition.txt", entry.Value);
                }
            }
        }     
    }
}


