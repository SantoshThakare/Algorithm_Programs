using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_program
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs :  \n Choose operation :"+
            
            "\n 1. Insertion Sort"+

            "\n 2. Permutation" +
            "\n 3. Anagram ");

            int option = Convert.ToInt32(Console.ReadLine());
            

            switch (option)
            {                             
                case 1:
                    InsertionSort sort = new InsertionSort();
                      sort.InsertionSortMethod();
                    break;
                case 2:
                    Console.WriteLine("Enter String to find Permutation ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Console.WriteLine(n);
                    permutation.Permutate(str, 0, n - 1);
                    break;
                case 3:
                    Anagram.FindingTheAnagram();
                    break;
                default:
                    System.Console.WriteLine("Choose correct option");
                    break;
            }
}
    }
}
