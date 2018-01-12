using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace average_value_array
{
    class Program
    {
        public void sumAverageElements(int[] arr, int size)
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("Averge Of Array is : " + average);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
