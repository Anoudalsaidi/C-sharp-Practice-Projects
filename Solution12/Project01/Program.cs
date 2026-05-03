using System;

namespace Project01
{
    internal class Program
    {
       
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

       
        static int Sum(int a, int b, int c,int d)
        {

            return a + b + c + d;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Sum(9, 10));
            Console.WriteLine(Sum(1.2, 2.5, 5.5));
            Console.WriteLine(Sum(1, 2, 3, 10));


        }
    }
}