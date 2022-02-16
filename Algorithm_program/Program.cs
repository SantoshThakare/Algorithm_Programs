using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String to find Permutation ");
            string str = Console.ReadLine();
            int n = str.Length;
            Console.WriteLine(n);
            permutation.Permutate(str, 1, n );

        }
    }
}
