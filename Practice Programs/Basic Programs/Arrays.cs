using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs.Basic_Programs
{
    public class ArraysPrograms
    {
        int[] arr = { 21, 36, 45, 82, 11, 9, 3, 852 };
        public void MaxMinValueInArray()
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int max = arr[0], min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"max value is {max} and min value is {min}");
            Array.Reverse(arr);
            Console.WriteLine($"{max} and {min}");
        }

        public void SecondMaxInArray()
        {
            int max1 = arr[0], max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else
                {
                    max2 = arr[i];
                }
            }
            Console.WriteLine($"Second max value is {max2}");
            Console.WriteLine(max2);        }
    }
}
