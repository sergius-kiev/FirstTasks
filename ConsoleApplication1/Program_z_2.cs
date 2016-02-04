using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Do you want can number?");
            string ansver = Console.ReadLine();
            int number = 0;
            if (ansver == "yes")
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            if (ansver == "no") 
            {
                Console.WriteLine();
            }
            
         
            Console.WriteLine("How many times do you want to enter it?");
            
            int raz = Convert.ToInt32(Console.ReadLine());
               //Console.WriteLine("Result"+ outer);
            for (int i = 1; i <= raz; i++)
              {
                  Console.WriteLine(number);
              }

            

            Console.ReadKey();



         //   for (int i = 0; raz < 5; i++) 
         //   {
            //System.out.println(number);
        ////    Console.WriteLine(i);

        
        }
    }
}
