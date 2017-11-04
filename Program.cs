    using System;
    using System.Collections.Generic;

    namespace BilingualDictionary
    {
        class Program
        {
            static void Main(string[] args)
            {
                BilingualDictionary dict = new BilingualDictionary();
                Console.WriteLine("Welcome to my dictionary!");
                dict.AddEntry();
                //dictionary.DeleteEntry();
                dict.ChangeEntry();
                dict.ListAll();
            }   
        }
    }
