using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashableclassexp
{
    class Hashableclass
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Akash");
            ht.Add("002", "Akshay");
            ht.Add("003", "Likith");
            ht.Add("004", "Punith");
            ht.Add("005", "Darshan");
            if(ht.ContainsValue("XYZ"))
            {
                Console.WriteLine("Name is already in the list");
            }
            else
            {
                ht.Add("006", "Abhi");
            }
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }
    }
}
