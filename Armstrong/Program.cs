using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp;

            Console.WriteLine("Input  a number: ");
            if(''%n, &num)

            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp)
                Console.WriteLine("%d is an Armstrong number.\n", temp);
            else
                Console.WriteLine("%d is not an Armstrong number.\n", temp);

        }
    }
}
