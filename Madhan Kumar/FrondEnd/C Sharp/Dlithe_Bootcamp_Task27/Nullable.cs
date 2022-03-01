using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_Task27_Nullable
{
     class Nullable
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 33;
            double? num3 = new double?();
            double? num4 = 3.14;
             
            bool? boolval= new bool?();
            Console.WriteLine("Nullables :{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("Nullable bool value: {0}", boolval);
            Console.ReadLine();

            //Null Coalescing Opreator (??)
            double? num5 = null;
            double? num6= 96;
            double num7;

            num7 = num5 ?? 5.34;
            Console.WriteLine(" Value of num7: {0}", num7);

            num7 = num6 ?? 5.34;
            Console.WriteLine(" Value of num7: {0}", num7);
            Console.ReadLine();

            //HasValue
            Nullable<int> i = null;
            if (i.HasValue)
                Console.WriteLine(i.HasValue);
            else
                Console.WriteLine("Null");
            //Helper class
            int? a = null;
            int b = 10;
            if (a < b)
                Console.WriteLine("a<b");
            else if (a > 10)
                Console.WriteLine("i>j");
            else if (a == 10)
                Console.WriteLine("i==j");
            else
                Console.WriteLine("Could not Compare");


        }
    }
}
