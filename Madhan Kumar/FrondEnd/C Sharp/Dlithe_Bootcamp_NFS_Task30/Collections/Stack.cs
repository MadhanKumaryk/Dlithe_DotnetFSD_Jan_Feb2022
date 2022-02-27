using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackexp
{
     class Stack
    {
        static void Main(string[] args)
        {
            var value = new Stack<int>();
            value.Push(23);
            value.Push(67);
            value.Push(54);
            value.Push(89);
            value.Push(65);
            value.Push(35);
            Console.WriteLine(value.Pop());
            Console.WriteLine(value.Peek());
            foreach(int item in value)
            {
                Console.WriteLine(item);
            }


        }
    }
}
