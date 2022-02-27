using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internal_Access_Specifier
{
     public class access
    {
        // String Variable declared as internal
       internal string name;
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            access ac = new access();
            Console.Write("Enter your name:\t");
            // Accepting value in internal variable
            ac.name = Console.ReadLine();
            ac.print();
            
        }
    }
}