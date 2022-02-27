using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsCopyPara
{
     class Copyandparameter
    {
        string name;
        int age;
        public Copyandparameter(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
        public Copyandparameter(Copyandparameter d)
        {
            this.name=d.name;
            this.age = d.age;
        }
        public void getData()
        {
            Console.WriteLine("Name is:{0}", name);
            Console.WriteLine("Age is:{0}", age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Copyandparameter obj = new Copyandparameter("Madhan",22);
            obj.getData();
            Copyandparameter obj2 = new Copyandparameter(obj);
            obj2.getData();
            Console.ReadLine();
        }
    }

}
