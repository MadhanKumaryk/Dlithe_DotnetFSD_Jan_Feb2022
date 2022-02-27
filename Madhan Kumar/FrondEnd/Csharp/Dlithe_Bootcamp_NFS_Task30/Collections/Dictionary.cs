using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryexp
{
     class Dictionary
    {
        static void Main(string[] args)
        {
            var pair = new Dictionary<string, string>();
            pair.Add("in", "India");
            pair.Add("ja", "Japan");
            pair.Add("ca", "canada");   
            pair.Add("us", "United States");
            Console.WriteLine("Keys present in dictionary");
            var key = new List<string>(pair.Keys);
            foreach (string k in key)
            {
                Console.WriteLine("{0}",k);
            }
            Console.WriteLine("Values present in dictionary");
            var value = new List<string>(pair.Values);
            foreach (string va in value)
            {
                Console.WriteLine("{0}", va);
            }
            Console.ReadLine();


        }
    }
}
