using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Person
    {
        private string name; 
       public string email; 


        public string Name   
        {

            get { return name; }
            set { name = value; }

        }

        public Person() 
        {
            email = "Madhankumaryk@gmail.com";
            Console.WriteLine(email);
        }
        public Person(out int a)
        {
            a = 25;


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            Person my2 = new Person(out int x);
            myObj.Name = "Madhan";
             myObj.email = "abc@abc.com";
            Console.WriteLine(myObj.Name);
            Console.Write(x);
        }
    }
}