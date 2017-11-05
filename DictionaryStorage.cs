using System;

namespace CodingProject
{
    class DictionaryStorage
    {
        BilingualDictionary dict = new BilingualDictionary();
        private void loadData()
        {
            //if(System.IO.File.)
        }   

        //Need to make a save location, current location is for testing
        public void saveData()
        {
            foreach(var entry in dict.Entries)
            {
                //Check if the key exists not to make duplicates, if not run command
                if(!System.IO.File.ReadAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\test.txt").Contains(entry.Key))
                {
                    System.IO.File.AppendAllText(@"C:\Users\Zoremeth\Edu\Personal Projects\Dictionary\test.txt", entry.Key + " " + entry.Value + "\n");
                }
            }

        }     
    }
}


