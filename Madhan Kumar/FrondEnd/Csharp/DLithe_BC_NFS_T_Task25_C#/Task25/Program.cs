using System;
namespace Inheritance
{
    class Shape
    {
        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int getArea()
        {
            width = 20;
            height = 15;
            return (width * height);
        }
    }
    class Rectanglemain
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Console.WriteLine("Total area:{0}",Rect.getArea());
            Console.ReadKey();  
        }
    }
}

