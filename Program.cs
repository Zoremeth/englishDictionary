    using System;
    using System.Collections.Generic;

    namespace CodingProject
    {
        class Program
        {
            static void Main(string[] args)
            {
                BilingualDictionary dict = new BilingualDictionary();

                DictionaryInterface dictInterface = new DictionaryInterface();

                dict.AddEntry("Hello", "World");
                dictInterface.mainInterface();
                Console.WriteLine("Back to Program.cs");
                dict.List(1);
                //dict.List(1);
                //Console.ReadKey(); //Just for temp pause
                //dict.ChangeEntry("Hello", "Best", "World");
                //dict.List(1);
                
            }   
        }
    }
