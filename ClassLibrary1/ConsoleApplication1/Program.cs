using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WillPower.Math.Demo;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FizzBuzz fb = new FizzBuzz();
                fb.Dividends.Add(3, "Fizz");
                fb.Dividends.Add(5, "Buzz");
                Console.Write(fb.GetOutput(1, 100));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\nPress Any Key to Exit...");
            Console.ReadKey();
        }
    }
}
