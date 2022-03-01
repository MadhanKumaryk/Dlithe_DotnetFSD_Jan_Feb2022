using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperationexp
{
  
    
       class ListOperation
    {
        static void Main(string[] args)
        {
            var value = new List<string>();
            value.Add("Cricket");
            value.Add("Football");
            value.Add("Vollyball");
            value.Add("Hockey");
            value.Remove("Cricket");
            foreach(string st in value)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }
        }
    }
   
}
