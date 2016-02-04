using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_z_4
{
    class Program
    {
        static void Main(string[] args)
        {// Это задание №4
            int n;
            Console.WriteLine("How much element of array");
            n = Convert.ToInt16(Console.ReadLine());
            double[] Data = new double[n];
            int i = 0;
            while (i < n) 
            {
                Console.WriteLine("Enter element of array");

                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            Console.WriteLine("Sort an array");
            Array.Sort(Data); 


            for (int k = 0; k < Data.Length; k++) // вывод отсортированного массива                 
            {
                Console.Write(" " + Data[k]);
            }
        }
    }
}
