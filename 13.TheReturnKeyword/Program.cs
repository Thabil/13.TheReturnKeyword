using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling a methods with a return type
            Console.WriteLine(cube(5));
            //Console.WriteLine(Math.Pow(5,3));
            //this wont give anything to console
            cube(5);

            //freezing the console
            Console.ReadLine();
            // declare a method with a return type int
        }
        static int cube(int number)
        {
            int result = number * number * number;
            return result;


        }
    }
}
