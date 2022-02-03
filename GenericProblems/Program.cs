// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Generic Problems==========");
            Console.WriteLine("\t->Please Choose the Option Which Can Be Executed<-");
            Console.WriteLine("\t1. FindMaxValueOutOfThree \n\t2. Exit");
            Console.Write("\tEnter The Selected Option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int x = 30, y = 20, z = 10;
                    double p = 15.33, q = 45.77, r = 77.88;
                    string s = "abc", s1 = "pqr", s2 = "xyz";
                    if (Generic.FindMaxValueOutOfThree(x, y, z) != 0)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThree(x, y, z), x, y, z);
                    if (Generic.FindMaxValueOutOfThree(p, q, r) != 0.0)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThree(p, q, r), p, q, r);
                    if (Generic.FindMaxValueOutOfThree(s, s1, s2) != null)
                        Console.WriteLine("\t{0} is maximum out of {1},{2},{3}", Generic.FindMaxValueOutOfThree(s, s1, s2), s, s1, s2);
                    break;
                case 2:
                default:
                    break;
            }
            Console.WriteLine("========================================================================================");
            Console.ReadLine();
        }
    }
}
