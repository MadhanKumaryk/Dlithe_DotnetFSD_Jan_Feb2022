﻿using System;


namespace Enployee


{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" Enter the Employee id");
            int empid = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Employee name");
            string empname = Console.ReadLine();
           
            Console.WriteLine("Enter Employee Salary");
             int empsalary = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the Employee age");
            int empage = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You entered " + empid);
            Console.WriteLine("Employee name is " + empname);
            Console.WriteLine("Emoloyee Salary " + empsalary);
            Console.WriteLine("Employee age is " + empage);




            //performing arithmatic operation
            Console.WriteLine("BASICS ARTIHMATIC OPERATIONS");
            Console.WriteLine("Enter 1 st value");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            int b = Convert.ToInt16(Console.ReadLine());

            int result;
            result = a + b;
            Console.WriteLine("Value is {0}", result);
            result = a - b;
            Console.WriteLine("Value is {0}", result);
            result = a * b;
            Console.WriteLine("Value is {0}", result);
            result = a / b;
            Console.WriteLine("Value is {0}", result);
            result = a % b;
            Console.WriteLine("Value is {0}", result);
            result = a++;
            Console.WriteLine("Value is {0}", result);
            result = a--;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();



            //swap of two nos 

            Console.WriteLine("SWAPPING OF TWO NOS ");
            Console.WriteLine("Enter 1 st value for swapping ");
            int j = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value for swapping");
            int k = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Before swap j= " + j + " k= " + k);
            j = j * k; //a=50 (5*10)      
            k = j / k; //b=5 (50/10)      
            j = j / k; //a=10 (50/5)    
            Console.Write("After swap j= " + j + " k= " + k);




            //find the largest nos 

            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of between  three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Enter 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is greatest \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest no. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest no \n\n");
            else
                Console.Write("The 3rd Number is the greatest no \n\n");
        }


    }
}



        
    

