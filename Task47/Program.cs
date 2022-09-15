using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа принимает на вход количество строк и столбцов и создаёт
    {                       // двумерный массив из вещественных чисел
        static void Main (string[] args)
        {
            double[,] createMatrix(int n, int m)
            {
                double[,] Matrix = new double[n, m];

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        Matrix[i, j] = new Random().NextDouble()*10;
                    }
                }

                return Matrix;
            }

            void printMatrix(double[,] Matrix)
            {
                for(int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        Console.Write("{0:0.00}  ", Matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Давайте создадим двумерный массив.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Созданный массив:");
            double[,] a = createMatrix(n,m);
            printMatrix(a);
        }
    }
}