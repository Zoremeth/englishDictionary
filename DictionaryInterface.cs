using System;
using System.IO;

namespace CodingProject
{
    public class DictionaryInterface
    {
        DictionaryStorage dictStorage = new DictionaryStorage();
        public void Run()
        {
            var dict = dictStorage.loadData(Path.Combine(Directory.GetCurrentDirectory(), "entries.txt"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            void Ui(){
                Console.Clear();
                Console.WriteLine("-----------------------\n|   Welcome to the dictionary\n|   Please select an option:");
                Console.WriteLine("|    1. Entries");
                Console.WriteLine("|    2. Search");
                Console.WriteLine("|    3. Quit");
                Console.WriteLine("-----------------------");
            }
            void UiEntry()
            {
                Console.Clear();
                Console.WriteLine("-----------------------\n|   Please select an option:");
                Console.WriteLine("|    1. Show all");
                Console.WriteLine("|    2. Create entry");
                Console.WriteLine("|    3. Delete entry");
                Console.WriteLine("|    3. Change entry");
                Console.WriteLine("-----------------------");
                var inputEntry = Console.ReadLine();
                switch ( inputEntry )
                {
                    case "1":
                        Console.Clear();
                        dict.ListAll();
                        Console.WriteLine("Press any key to return.");
                        Console.ReadKey();
                        Ui();
                        break;
                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Please specify the entry you would like to add:");
                        string word = Console.ReadLine();
                        Console.WriteLine("Please specify the definition of the entry:");
                        string definition = Console.ReadLine();
                        dict.AddEntry(word, definition);
                        Console.WriteLine("Entry added. Press any key to return.");
                        Console.ReadKey();
                        Ui();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Please specify the entry you would like to delete:");
                        string deleteKey = Console.ReadLine();
                        dict.DeleteEntry(deleteKey);
                        Console.WriteLine("Entry deleted. Press any key to return.");
                        Console.ReadKey();
                        Ui();
                        break;
                    
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Please specify the entry you would like to edit:");
                        string inputKey = Console.ReadLine();
                        Console.WriteLine("Please specify the new entry.\n(If you do not wish to edit the entry leave it blank.)");
                        string correctedWord = Console.ReadLine();
                        Console.WriteLine("Please specify the definition of the (newly) entered entry:");
                        string correctedDefinition = Console.ReadLine();
                        dict.ChangeEntry(inputKey, correctedWord, correctedDefinition);
                        Console.WriteLine("Entry changed. Press any key to return.");
                        Console.ReadKey();
                        Ui();
                        break;
                }    
            }
            Ui();
            var inputMain = Console.ReadLine();
            switch( inputMain )
            {
                case "1":
                    UiEntry();
                    break;
                case "2":
                    Console.WriteLine("Type in word to search:");
                    var inputKey = Console.ReadLine();
                    string result = dict.SearchWord(inputKey);
                    if( result == "")
                    {
                        Console.WriteLine("Word: {0}\nDefinition: {1}", inputKey, result);
                    }
                    else
                    {
                        Console.WriteLine("Could not find entry.");
                    }
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Ui();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Quitting.");
                    break;
            }
            dictStorage.saveData(dict, Path.Combine(Directory.GetCurrentDirectory(), "entries.txt"));            
        }
    }
}