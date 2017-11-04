    using System;
    using System.Collections.Generic;

    namespace Dictionary
    {
        class Program
        {
            static void Main(string[] args)
            {
                Entries entry = new Entries(); 
                Console.WriteLine("Welcome to my dictionary!");
                entry.AddEntry();
                //dictionary.DeleteEntry();
                //Console.ReadKey();
                entry.ChangeEntry();
                entry.ListAll();
            }   
        }
    }
