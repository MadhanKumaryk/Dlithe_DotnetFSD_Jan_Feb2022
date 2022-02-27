using System;
namespace abst
{
    public abstract class Vehical
    {
        public abstract void display();
        protected string name;
        public abstract string Name
        {
            get;
            set;
        }
        public abstract void calculate(double x);
    }
    public class Bus : Vehical
    {
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override void display()
        {
            Console.WriteLine("Bus");

        }
        public override void calculate(double x)
        {
            Console.WriteLine("Squre root is " + Math.Sqrt(x));
        }
    }


    public class Car : Vehical
    {
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override void display()
        {
            Console.WriteLine("CAR");

        }
        public override void calculate(double x)
        {
            Console.WriteLine("Squre root is " + (x * x));
        }

    }

    public class Motorcycle : Vehical
    {
        // provide implementation of abstract method
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void display()
        {
            Console.WriteLine("Motorcycle");
        }
        public override void calculate(double x)
        {
            Console.WriteLine("CUBE is :" + (x * x * x));
        }
    }

    public class MyClass
    {
        public static void Main()
        {
            Vehical v;
            v = new Bus();
            Console.WriteLine(v.Name = "ABC");
            v.display();
            v.calculate(3);
            v = new Car();
            Console.WriteLine(v.Name = "XYZ");
            v.display();
            v.calculate(3);
            v = new Motorcycle();
            Console.WriteLine(v.Name = "012");
            v.display();
            v.calculate(3);

        }
    }
}

           