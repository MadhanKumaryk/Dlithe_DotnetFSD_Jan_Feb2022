using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterfaceDemo
{
    interface interface1 //interface
{
void Test();
    void Show();
}
    interface interface2   //interface
{
    void Test();
    void Show();
}
class ImplementInterafce : interface1 , interface2
{
public void Test()  //void
{
    Console.WriteLine("Test method is implemented");
}
public void Show()  //void
{
    Console.WriteLine("Show method is implemented");
}
}
class Program
{
    static void Main(string[] args)
    {
        ImplementInterafce obj = new ImplementInterafce();
        obj.Test();
        obj.Show();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
}

