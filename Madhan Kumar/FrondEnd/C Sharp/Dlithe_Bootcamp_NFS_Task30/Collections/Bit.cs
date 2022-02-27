using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitarray
{
     class Bit
    {
        static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            byte[] a = { 0 };
            byte[] b = { 10};
            ba1= new BitArray(a);
            ba2 = new BitArray(b);
            Console.WriteLine("Bit array ba1: 0");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", ba1[i]);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Bit array ba2: 10");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", ba2[i]);
            }
            Console.WriteLine("----------------------------------");
            BitArray ba3 = new BitArray(4);
            ba3 = ba1.And(ba2);
            Console.WriteLine("Bit array ba3 after AND operation: 0");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", ba3[i]);
            }
            Console.WriteLine("-------------------");
            ba3 = ba1.Or(ba2);
            Console.WriteLine("Bit array ba3 after OR operation: 15");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", ba3[i]);
            }
            Console.WriteLine("---------------------");

            Console.ReadKey();



        }
    }
}
