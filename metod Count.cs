using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] erazi = { 3, 6, 7, 8, 34, 5, 4 };
            int x = 3;
            Console.WriteLine(Count(erazi, x));


            static int Count(int[] erazi, int x)
            {
                int count = 0;
                foreach (int item in erazi)
                {
                    if (x / item == 1)
                    {
                        Console.WriteLine(count);
                    }
                    count++;
                }



            }
        }
    }
}
