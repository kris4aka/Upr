using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();

            }
        }
    }
}
