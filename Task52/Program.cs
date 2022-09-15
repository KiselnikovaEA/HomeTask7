using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа считает среднее арифметическое всех строк массива
    {
        static void Main (string[] args)
        {
            int[,] createMatrix(int n, int m)
            {
                int[,] Matrix = new int[n, m];

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        Matrix[i, j] = new Random().Next(0, 10);
                    }
                }

                return Matrix;
            }

            void printMatrix(int[,] Matrix)
            {
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Console.Write($"{Matrix[i, j]}  ");
                    }
                    Console.WriteLine();
                }
            }

            double[] getAvgColumns(int[,] Matrix)
            {
                double[] Array = new double[Matrix.GetLength(1)];
                double avg;
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    avg = 0;
                    for(int i = 0; i < Matrix.GetLength(0); i++)
                    {
                        avg = avg + Matrix[i,j];
                    }
                    avg = avg / Matrix.GetLength(0);
                    Array[j] = avg;
                }
                return Array;
            }

            void printArray(double[] Array)
            {
                for(int i = 0; i < Array.Length; i++)
                {
                    Console.Write($"{Array[i]} ");
                }
                Console.WriteLine();
            }

           /* Console.WriteLine("Давайте создадим двумерный массив.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());*/
            int[,] a = createMatrix(4,3);
            printMatrix(a);
            double[] avg = getAvgColumns(a);
            printArray(avg);
        }
    }
}