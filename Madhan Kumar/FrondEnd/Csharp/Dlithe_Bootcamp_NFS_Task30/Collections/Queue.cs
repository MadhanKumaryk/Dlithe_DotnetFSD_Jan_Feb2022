using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueexp
{
     class Queue
    {
        static void Main(string[] args)
        {
            var value = new Queue<string>();
            value.Enqueue("One");
            value.Enqueue("Two");
            value.Enqueue("Three");
            value.Enqueue("Four");
            value.Enqueue("Five");
            value.Enqueue("Six");
            Console.WriteLine(value.Dequeue());
            Console.WriteLine(value.Peek());
            Console.WriteLine();
            foreach(string st in value)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }

        }
    }
}
