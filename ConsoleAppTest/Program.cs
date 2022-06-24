using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, -5, 6, -7 };
            bool negativeInputFound = false;
            int i = 0;
            while (!negativeInputFound)
            {
                if (input[i] < 0)
                {
                    negativeInputFound = true;
                }
                i++;
            }

            Console.WriteLine(input[(i == 0 ? 0 : --i)]);
            Console.ReadKey();
        }
    }
}
