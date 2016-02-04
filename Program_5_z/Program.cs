using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_5_z
{
    class Program
    {
        static void Main(string[] args)
        {//Это задание №5
            int n;
            Console.WriteLine("How much element of array");
            n = Convert.ToInt32(Console.ReadLine());
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Enter element of array");

                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }


            for (int k = 0; k < n; k++)
            {
                if (Data[k] % 2 == 0)
                {
                    Console.WriteLine(Data[k]);
                }

            }
        Console.ReadKey();
        //return 0;
        }
    
    }
}
