using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CodingProject
{
    class DictionaryStorage
    {

        public BilingualDictionary loadData(string dataDictionary)
        {
            var dict = new BilingualDictionary();
            if (File.Exists(dataDictionary))
            {
                var newDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(dataDictionary));
                foreach ( var entry in newDict)
                {
                    dict.AddEntry( entry.Key, entry.Value);
                }
                File.Delete(dataDictionary + ".bak");
            }
            else
            {
                Console.WriteLine("No pre-existing dictionary found.");
            }
            return dict;
        }
        public void saveData(BilingualDictionary dict, string dataDictionary)
        {
            bool backupData()
            {
                if ( File.Exists(dataDictionary))
                {
                    File.Move(dataDictionary, dataDictionary + ".bak");
                }
                return (File.Exists(dataDictionary));
            }
            bool backupSuccess = backupData();
            if (backupSuccess == false)
            {
                File.WriteAllText(dataDictionary, JsonConvert.SerializeObject(new Dictionary<string, string>(dict.Entries)));
            }
            else
            {
                File.Move(dataDictionary + ".bak", dataDictionary);
                Console.WriteLine("Saving failed.");
            }
        }
    }
}