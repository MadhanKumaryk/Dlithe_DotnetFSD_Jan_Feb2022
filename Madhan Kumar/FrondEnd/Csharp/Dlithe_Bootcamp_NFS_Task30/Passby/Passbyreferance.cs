using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passbyref
{
    class Passbyreferance
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            Passbyreferance pa = new Passbyreferance();
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swapping a:{0}", a);
            Console.WriteLine("Before swapping b:{0}", b);
            pa.swap(ref a, ref b);
            Console.WriteLine("After swapping a:{0}", a);
            Console.WriteLine("After swapping b:{0}", b);
            Console.ReadLine();


        }
    }


}
