using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraystwo 
{
    class Twodarrays
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int i, j;
            for(i=0;i<3; i++)
            {
                for(j=0;j<3; j++)
                {
                    Console.WriteLine( "a[{0},{1}]={2}",i,j,a[i,j]);
                }


            }
            Console.ReadKey();
        }

    }
}
