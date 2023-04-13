using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, mx, n = 10;


            Console.Write("\n\nFind maximum   element in an array :\n");


            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                {
                }
            }
            Console.Write("Maximum element is : {0}\n", mx);
        }
    }
}


