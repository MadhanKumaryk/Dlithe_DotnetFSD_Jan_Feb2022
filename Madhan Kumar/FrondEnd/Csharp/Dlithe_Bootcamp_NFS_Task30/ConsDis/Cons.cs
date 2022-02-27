using System;
namespace Constructor
{
    class Construct
    {
        public string a1;
        public string a2;
        public string sname;
        public int sid;
        public int sduration;
        
        public Construct()
        {
            Console.WriteLine("Student details");

        }
        public Construct(string name , int id)
        {
            sid = id;
            sname = name;
        }
        public Construct(string session1,string session2,int duration)
        {
            a1 = session1;
            a2 = session2;
            sduration = duration;
        }
        static void Main(string[] args)
        {
            Construct c0= new Construct();
            Construct c1 = new Construct("Madhan",45);
            Construct c2 = new Construct("Java","C++",3);
            Console.WriteLine("=======");
            Console.WriteLine(c1.sid + " " + c1.sname);
            Console.WriteLine(c2.a1 + " " + c2.a2 + " " + c2.sduration);
            Console.ReadLine();
            
        }
    }
}
