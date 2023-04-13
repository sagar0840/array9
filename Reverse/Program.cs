using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void reverse<T>(this T[] array)
            {
                int n = array.Length;
                T[] aux = new T[n];

                for (int i = 0; i < n; i++)
                {
                    aux[n - 1 - i] = array[i];
                }

                for (int i = 0; i < n; i++)
                {
                    array[i] = aux[i];
                }
            }
        }

        public class Example
        {
            public static void Main()
            {
                int[] array = { 2, 4, 6, 8 };

                array.Reverse();
                Console.WriteLine($"reverse is {Reverse}");
            }
        }
    }
}

