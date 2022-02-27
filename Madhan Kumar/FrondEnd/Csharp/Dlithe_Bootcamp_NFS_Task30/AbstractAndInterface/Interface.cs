using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    interface IFirstInterface
    {
        string Name { get; set; }
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }
    interface IThirdInterface
    {
        void myOtherMethod1(); // interface method
    }

   
    class DemoClass : IFirstInterface, ISecondInterface, IThirdInterface
    {
        public string Name
        {
            get;
            set;
        }
        public void myMethod()
        {
            Console.WriteLine(" First interface");

        }
        public void myOtherMethod()
        {
            Console.WriteLine(" Second Interface");
        }
        public void myOtherMethod1()
        {
            Console.WriteLine(" Third Interface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.Name = "Madhan Kumar";
            myObj.myMethod();
            myObj.myOtherMethod();
            myObj.myOtherMethod1();
            Console.WriteLine(myObj.Name);
        }
    }
}