using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortedlistexp
{
     class Sortedlist
    {
        static void Main(string[] args)
        {
            var value = new SortedList<string, int>();
            value.Add("java", 4);
            value.Add("javascript", 5);
            value.Add("c-sharp", 3);
            value.Add("dotnet", 7);
            value.Clear();
            foreach(var pair in value)
            {
                Console.WriteLine(pair);
                Console.ReadLine();
                
            }

        }
    }
}
