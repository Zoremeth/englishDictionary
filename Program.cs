    using System;
    using System.Collections.Generic;

    namespace CodingProject
    {
        class Program
        {
            static void Main(string[] args)
            {
                BilingualDictionary dict = new BilingualDictionary();
                dict.AddEntry("Hello", "World");
                dict.ListAll();
                Console.ReadKey(); //Just for temp pause
                dict.ChangeEntry("Hello", "Best", "World");
                dict.ListAll();
                //DictionaryInterface();

            }   
        }
    }
