using System;

namespace CodingProject
{
    public class DictionaryInterface
    { 
        BilingualDictionary dict = new BilingualDictionary();
        public void mainInterface()
        {
            Console.WriteLine("-----------------------\nWelcome to the dictionary\nPlease select an option:");
            dict.List(ListFormat.All);
        }
    }
}