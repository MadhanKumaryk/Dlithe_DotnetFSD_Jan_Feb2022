using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distructor
{
     class One
    {
        ~One()
        {
            System.Console.WriteLine("Ones distructor is called");
        }

    }
    class  Two : One
    {
       ~Two()
        {
            System.Console.WriteLine("Twos distructor is called");
        }

    }
    class Three:Two
    {
     ~Three()
        {
            System.Console.WriteLine("Threes distructor is called");
        }

    }
    class TestDestructor
    {
        static void Main(string[] args)
        {
            Three th = new Three();
        }
    }

}
