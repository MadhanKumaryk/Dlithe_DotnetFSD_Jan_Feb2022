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
            Console.WriteLine("Fullname:{0}", fullname);
            Console.WriteLine("--------");

            //string constractor 
            char[] letters = { 'H', 'e', 'l', 'l', '0' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}", greetings);
            Console.WriteLine("--------");

            //methods returning string//
            string[] sarray = { "Hello", "my", "name", "is", "madhan" };
            string message = String.Join("", sarray);//Join
            Console.WriteLine("Message:{0}", message);
            Console.WriteLine("----");
            //String format
            int num = 302;
            string numStr = String.Format("Number {0, 0:D5}", num);
            Console.WriteLine(numStr);

            //compare
            string str1 = "Csharp";
            string str2 = "Csharp2";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "and " + str2 + " are equal");
            }
            else
            {
                Console.WriteLine(str1 + "and" + str2 + "are not equal");
            }
            Console.WriteLine("-------");
            ///contains
            string str = "welckome to c#";
            if(str.Contains("c#"))
            {
                Console.WriteLine("the sequence c# was found");

            }
            Console.WriteLine("--------");
            /////substring
            string str3 = "Example of Substring";
            Console.WriteLine(str3);
            string substr = str3.Substring(6);
            Console.WriteLine(substr);
            Console.WriteLine("--------");

            //join
            string[] staray = new string[] { "red", " green", "black", "blue", "yellow" };
            string str4 = String.Join("\n", staray);
            Console.WriteLine(str4);
            Console.WriteLine("----------");

            //compareOrdinal()
            string s11 = "hello";
            string s12 = "hello";
            string s13 = "cshaarp";
            string s14 = "mello";
            Console.WriteLine(string.CompareOrdinal(s11,s12));
            Console.WriteLine(string.CompareOrdinal(s11, s13));
            Console.WriteLine(string.CompareOrdinal(s11, s14));
            Console.WriteLine("===========");
             
            //concat method
            Console.WriteLine(string.Concat(s11, s12));
            Console.WriteLine("======");

            //copy
            string sc = string.Copy(s11);
            Console.WriteLine(s11);
            Console.WriteLine(sc);
            Console.WriteLine("======");

            //Copyto()
            string s15 = "hello how are you?";
            char[] ch1 = new char[10];
            s15.CopyTo(5, ch1, 0, 7);
            Console.WriteLine(ch1);
            Console.WriteLine("====");
             
            //Endswith
            Console.WriteLine(s11.EndsWith("everyone"));
            Console.WriteLine("====");

            ///Equals
            Console.WriteLine(s11.Equals(s12));
            Console.WriteLine("====");

            //GetEnumerator()
            string s16 = "Enumaertor example";
            CharEnumerator ch2 = s16.GetEnumerator();
            while(ch2.MoveNext())
            {
                Console.WriteLine(ch2.Current); 
            }
            Console.WriteLine("=========");

            //ToCharArray()
            char[] ch3 = s16.ToCharArray();
            foreach(char c in ch3)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("=========");
            //split
            string s17 = "Hello C Sharp";
            string[] s18 = s17.Split(' ');
            foreach (string s in s18)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("=========");
            //startwith
            bool b1 = s17.StartsWith("h");
            bool b2 = s17.StartsWith("H");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine("=========");

            //remove
            string s19 = "Hello C#";
            string s20 = s19.Remove(2);
            Console.WriteLine(s20);
            Console.WriteLine("=========");
            //replace
            string s21 = s19.Replace('C', 'F');
            Console.WriteLine(s21);
            Console.WriteLine("=========");








        }
    }
}