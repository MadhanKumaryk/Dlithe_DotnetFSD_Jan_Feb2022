using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsStatic
{
     class StaticCons
    {
        static int val1;
        int val2;
        static StaticCons()
        {
            Console.WriteLine("This is static constructor ");
            val1 = 40;
        }
        public StaticCons(int val3)
        {
            Console.WriteLine("This is instance constructor ");
            val2 = val3;

        }
        private void show()
        {
            Console.WriteLine("First value="+ val1);
            Console.WriteLine("Second value=" + val2);
        }
        static void Main(string[] args)
        {
            StaticCons c1 = new StaticCons(100);
            StaticCons c2 = new StaticCons(150);
            c1.show();
            c2.show();
            Console.ReadKey();

        }

    }
}
