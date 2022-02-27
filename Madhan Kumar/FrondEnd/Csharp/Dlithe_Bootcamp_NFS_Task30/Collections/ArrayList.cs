using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace ArrayListExp
{
    class ArrayProgram
    {
        static void Main(string[] args)
        {
            var data = new ArrayList();
            data.Add("string data type");
            data.Add(1);
            data.Add(12.3);
            data.Add(34);
            data.Remove(1);
            foreach (object obj in data)
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }
    }
}