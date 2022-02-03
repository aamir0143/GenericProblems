﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class Generic
    {
        //UC 1: Given 3 Integers Find The Maximum.
        public static int FindMaxValueOutOfThree(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("\teither 2 or 3 having same value/equals");
                return 0;
            }
        }
        //UC 2: Given 3 Floats Find The Maximum.
        public static double FindMaxValueOutOfThree(double first, double second, double third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("\teither 2 or 3 having same value/equals");
                return 0.0;
            }
        }
    }
}
