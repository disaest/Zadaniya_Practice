using System;

namespace Zadaniya{
    class Program{
        static void Main(string[] args){
            // 1
            /*
            Console.Write("Введите ширину: ");
            double width = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите высоту: ");
            double height = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Площадь: {width * height}");
            Console.WriteLine($"Периметр: {2 * (width + height)}");
            */
            // 2
            /*
            Console.Write("Введите сумму в рублях: ");
            double rubles = double.Parse(Console.ReadLine() ?? "0");
            double rate = 90.0;
            Console.WriteLine($"В долларах: {rubles / rate:F2}");
            */
            // 3
            /*
            double sum = 0;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"День {i}: ");
                sum += double.Parse(Console.ReadLine() ?? "0");
            }
            Console.WriteLine($"Средняя температура: {sum / 7:F2}");
            */
            // 4
            /*
            double[] avg = new double[3];
            for (int s = 1; s <= 3; s++)
            {
                Console.WriteLine($"Студент {s}:");
                double sumG = 0;
                for (int g = 1; g <= 5; g++)
                {
                    Console.Write($"Оценка {g}: ");
                    sumG += double.Parse(Console.ReadLine() ?? "0");
                }
                avg[s - 1] = sumG / 5;
            }
            for (int i = 0; i < avg.Length; i++)
                Console.WriteLine($"Средний балл студента {i + 1}: {avg[i]:F2}");
            */

            // 5
            int[,] matrix = new int[3, 3];
            int[,] transposed = new int[3, 3];

            Console.WriteLine("Введите 9 чисел через пробел:");
            string[] input = (Console.ReadLine() ?? "").Split(' ');

            if (input.Length < 9)
            {
                Console.WriteLine("Ошибка: нужно 9 чисел!");
                return;
            }

            int index = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(input[index]);
                    index++;
                }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    transposed[j, i] = matrix[i, j];

            Console.WriteLine("\nБыло:");
            PrintMatrix(matrix);
            Console.WriteLine("\nСтало:");
            PrintMatrix(transposed);
        }

        static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}