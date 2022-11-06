using System;

namespace HomeTasks_KisEA
{
    class Program           // Программа принимает на вход номер строки и столбца и
    {                       // показывает пользателю элемент по этому индексу
        static void Main (string[] args)    // с учётом, что пользователь не знает об отсчёте индексов с нуля
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

            void showElement(double[,] Matrix)
            {
                Console.WriteLine("Какой элемент Вам показать?");
                Console.Write("Строка: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Столбец: ");
                int m = Convert.ToInt32(Console.ReadLine());
                
                if(n <= Matrix.GetLength(0) && n > 0 && m <= Matrix.GetLength(1) && m > 0)
                    Console.WriteLine($"Выбранный элемент имеет значение {Matrix[n-1, m-1]}");
                else Console.WriteLine("Выбранного элемента не существует");
            }

            Console.WriteLine("Давайте создадим двумерный массив.");
            Console.Write("Количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            
            double[,] a = createMatrix(n,m);
            printMatrix(a);
            showElement(a);
        }
    }
}