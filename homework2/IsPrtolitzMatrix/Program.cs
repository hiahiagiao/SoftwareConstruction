using System;

namespace IsPrtolitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            isPrtolitzMatrix(inputArray());
            static int[,] inputArray()
            {
                Console.WriteLine("input the number of rows");
                int rows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("inout the number of columns");
                int columns = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[rows,columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return array;
            }
            static bool isPrtolitzMatrix(int[,] array)
            {
                int miner = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
                for(int i = 0; i < miner; i++)
                {
                    if (array[i,i] != array[0,0])
                    {

                        Console.WriteLine("false");
                        return false;
                    }
                }
                Console.WriteLine("true");
                return true;
             }
        }
    }
}
