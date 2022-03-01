using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 namespace Passbyvalue
{
    class Passvalue
    {
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap,Value of x:{0}", x);
            Console.WriteLine("After swap,Value of y:{0}", y);
        }
        static void Main(string[] args)
        {
            Passvalue obj = new Passvalue();
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swap,Value of a: {0}", a);
            Console.WriteLine("Before swap,Value of b: {0}", b);
            obj.swap(a, b);
            Console.WriteLine("After swap,Value of a:{0}", a);
            Console.WriteLine("After swap,Value of b:{0}", b);
           
            Console.ReadLine();
        }
       
    }

}
