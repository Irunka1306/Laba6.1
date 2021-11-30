using System;
using System.Collections.Generic;

namespace lab6._1
{
    public class Program
    {
        public static List<int> Iterative(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < 0)
                {
                    result.Add(arr[i]);
                    Console.Write(arr[i] + "\t");
                }
            }
            return result;
        }

       public static void Recursive(int[] arr, int index)
        {
            if (index < arr.Length)
            {
                if (arr[index] % 2 == 0 && arr[index] < 0)
                {
                    Console.Write(arr[index] + "\t");
                }
                index++;

                Recursive(arr, index);
            }
        }

       public static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 34);
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("Iterative result : ");
            Iterative(array);

            Console.WriteLine();
            Console.WriteLine("Recursuve result : ");
            Recursive(array, 0);
        }
    }
}

