using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Dixct
    {
        static void Main()
        {
            //initialize dictionary
            Dictionary<string, int> agedict = new Dictionary<string, int>();

            //add key-value pairs to the dictionary
            agedict.Add("Rohit", 27);
            agedict.Add("Ajay", 28);
            agedict.Add("Sachin", 25);
            agedict.Add("Sachin", 25);

            //print all the elements in the dict
            Console.WriteLine("ALl elements in the dictionary");
            foreach (KeyValuePair<string, int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");
            }


            //modify dict

            agedict["Rohit"]=29;

            //print modifyed all the elements in the dict
            Console.WriteLine("ALl elements in the dictionary");
            foreach (KeyValuePair<string, int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");
            }

            //remove element in dictionay
            agedict.Remove("Sachin");

            //search element in the dictnory
            if (agedict.ContainsKey("Rohit")) 

            {
                Console.WriteLine("Exists in dictionary");
            }

            agedict.Clear();
            Console.WriteLine(agedict.Count());


        }
    }
}
