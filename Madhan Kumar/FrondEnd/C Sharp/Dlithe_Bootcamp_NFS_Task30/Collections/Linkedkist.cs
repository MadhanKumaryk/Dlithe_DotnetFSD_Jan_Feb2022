using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistexp
{
     class Linkedkist
    {
        static void Main(string[] args)
        {
            var lk = new LinkedList<int>();
            lk.AddLast(14);
            lk.AddLast(15);
            lk.AddLast(16);
            lk.AddLast(17);
            lk.AddLast(18);
            lk.AddFirst(6);
            lk.AddFirst(7);
            LinkedListNode<int> node = lk.Find(14);
            lk.AddBefore(node, 40);
            foreach (int num in lk)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }

        }
    }
}
