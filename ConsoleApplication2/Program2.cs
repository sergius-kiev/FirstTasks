using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How number №1?");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How number №2?");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select operation? + or -");
            string operation = (Console.ReadLine());

            int result = 0;
            if (operation == "+")
            {
                result = one + two;
            }
            else 
            {
                result = one - two;
            }

            Console.WriteLine("Result"+ result);
           
       

            Console.ReadKey();
        }
    }
}
