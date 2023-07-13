using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks in pre: ");
            int preMarks = int.Parse(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.Write("Enter marks in final: ");
                int finalMarks = int.Parse(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Result: Selected");
                }
                else
                {
                    Console.WriteLine("Result: Fail in final");
                }
            }
            else
            {
                Console.WriteLine("Result: Fail in pre");

            }
        }
    }
}
