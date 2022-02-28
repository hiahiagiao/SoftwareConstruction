using System;

namespace AnalyseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = inputArray();
            Console.WriteLine(maxNum(a));
            Console.WriteLine(minNum(a));
            Console.WriteLine(arraySum(a));
            Console.WriteLine(average(a));

            static int[] inputArray()
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                return array;
            }

            static int maxNum(int[] array)
            {
                int max = array[1];
                foreach (int i in array)
                {
                    max = array[i] > max ? array[i] : max;
                }
                return max;
            }
            static int minNum(int[] array)
            {
                int min = array[1];
                foreach (int i in array)
                {
                    if (array[i] < min)
                    {
                        min = array[i] < min ? array[i] : min;
                    }
                }
                return min;
            }
            static int arraySum(int[] array)
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                return sum;
            }
            static int average(int[] array)
            {
                int sum = arraySum(array);
                int average = sum / array.Length;
                return average;
            }
        }
    }
}
