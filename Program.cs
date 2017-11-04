    using System;
    using System.Collections.Generic;

    namespace englishDictionary
    {
        class Program
        {
            static void Main(string[] args)
            {
                EnglishDictionary dict = new EnglishDictionary();
                Console.WriteLine("Welcome to my dictionary!");
                dict.AddEntry();
                //dictionary.DeleteEntry();
                //Console.ReadKey();
                dict.ChangeEntry();
                dict.ListAll();
            }   
        }
    }
