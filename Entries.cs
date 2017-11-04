using System;

namespace Dictionary
{
    class Entries
    {
        static void Main()
        {
            Dictionary defineDictionary = new Dictionary();
            var dictionary = defineDictionary.englishDictionary;


        }
        public void AddEntry()
        {
            Console.WriteLine("Add entry");
            Console.WriteLine("Enter word:");
            string word = Console.ReadLine();
            Console.WriteLine("Enter definition:");
            string definition = Console.ReadLine();
            Console.WriteLine("Adding entry: {0}, {1}", word, definition);
            Dictionary.Add(word, definition);
        }
        
        public void DeleteEntry()
        {
            Console.WriteLine("What entry would you like to delete?:");
            ListKeys();
            string delKey = Console.ReadLine();
            Console.WriteLine("Deleting entry: {0}", delKey);
            if (dictionary.ContainsKey(delKey))
            {
                dictionary.Remove(delKey);
            }else{
                Console.WriteLine("Could not find entry.");
            }
                
        }
            
        public void ChangeEntry()
        {
            Console.WriteLine("What value would you like to change?");
            ListKeys();
            string input = Console.ReadLine();
            if(dictionary.ContainsKey(input)){
                Console.WriteLine("What would you like to change it to?");
                string correction = Console.ReadLine();
                dictionary.Remove(input);
                dictionary.Add(correction, "Test");
             }else{
                Console.WriteLine("Entry does not exist");
            }
        }

        public void ListAll()
        {
            Console.WriteLine("Currently stored entries:");
            foreach (var entries in dictionary)
            {
                Console.WriteLine("{0}, {1}", entries.Key, entries.Value);
            }
        }

        public void ListKeys()
        {
            foreach (var key in dictionary)
            {
                Console.WriteLine("{0}", key.Key); 
            }
        }
        public void ListValues()
        {
            foreach (var values in dictionary)
            {
                Console.WriteLine("{0}", values.Value); 
            }
        }
    }
}