using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passbyoutexp
{
     class Passbyout
    {
        public void getValues(out int x ,out int y)
        {
            Console.WriteLine("Enter the first value:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second value:");
            y = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            Passbyout pa = new Passbyout();
            int a, b;
            pa.getValues(out a, out b);
            Console.WriteLine("After method call value of  a:{0}",a);
            Console.WriteLine("After method call value of  b:{0}", b);
            Console.ReadLine();

        }
    }
}
