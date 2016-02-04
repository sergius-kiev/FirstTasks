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
            if (ansver == "yes");
            {
                string number = Console.ReadLine();
            }
            if (ansver == "no") ; 
            {
                Console.ReadKey();
            }
            
            Console.WriteLine("How many times do you want to enter it?");
            int raz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; raz < 5; i++) 
            {
            //System.out.println(number);

            Console.WriteLine("Result"+ result);
            }
        }
    }
}
