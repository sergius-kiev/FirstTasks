using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How long vector?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[n];

            int n;
            Console.WriteLine("How much element of array");
            n = Convert.ToInt16(Console.ReadLine());
            double[] Data = new double[n];
            int i = 0;
            while (i < n) ;
            {
                Console.WriteLine("Enter element of array");
                
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            //for (i = 0; i < n; i = i + 1)
                //Console.WriteLine("Element[" + i + "]: " + Data[i]);
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            int mid = summ / array.Length;
            Console.ReadKey();
        }
    }
}
