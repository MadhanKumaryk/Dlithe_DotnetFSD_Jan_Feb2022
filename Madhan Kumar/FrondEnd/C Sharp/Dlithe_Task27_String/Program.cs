using System;
namespace StringsApplication
{
    class Strings
    {
        static void Main(string[] args)
        {
            string s1 = "string";//using string key word
            String s2 = "Class string";//using string class

            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s4 = new string(ch);
            Console.WriteLine(s4);
            Console.WriteLine("-------");
            // string concatination
            string fname, lname;
            fname = "Madhan";
            lname = "Kumar";
            string fullname = fname + lname;
            Console.WriteLine("Fullname:{0}",fullname);
            Console.WriteLine("--------");

                //string constractor 
            char[] letters = { 'H', 'e', 'l', 'l', '0' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}",greetings);
            Console.WriteLine("--------");

            //methods returning string//
            string[] sarray = { "Hello", "my", "name", "is", "madhan" };
            string message = String.Join("", sarray);//Join
            Console.WriteLine("Message:{0}",message);
            Console.WriteLine("----");
            //String format
            int num = 302;
            string numStr = String.Format("Number {0, 0:D5}", num);
            Console.WriteLine(numStr);

            //compare
            string str1 = "Csharp";
            string str2 = "Csharp2";
            if(String)

        }
    }
}