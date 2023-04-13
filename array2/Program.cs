using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 9, 2, 4, 3, 1};
            // Sort array from 1st element to 6th element. Skil 0th element.
            Array.Sort(intArray, 1, 6);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
        }
    }
    
}
