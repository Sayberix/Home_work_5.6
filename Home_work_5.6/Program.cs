using System;

namespace Home_work_5._6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            // заданных уравнениями y = k1 * x + b1,
            //                      y = k2 * x + b2;
            // значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5,
            // b2 = 4, k2 = 9   -> (-0,5; -0,5)

            double[] b = new double[2];
            double[] k = new double[2];
            double x = 0.0, y = 0.0;
            Console.Write("Введите значение b1: ");
            b[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            b[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение k1: ");
            k[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            k[1] = Convert.ToInt32(Console.ReadLine());

            if (k[0] == k[1])        // Проверка, не является ли прямые по заданным координатам одинаковыми или параллельными?
            {
                Console.WriteLine("Заданные координаты являются двумя параллельными прямыми или прямые - совпадают! Программа завершает работу!");
                return;
            }

            x = FindX(b, k);
            y = FindY(b, k, x);

            Console.WriteLine($"Точка пересечения двух прямых по заданным координатам - X = {x}; Y = {y}");

            double FindX(double [] b, double[] k)                         // Поиск X
            {
                return ((-b[1] + b[0]) / (-k[0] + k[1]));
            }

            double FindY(double[] b, double[] k, double x)                // Поиск Y
            {
                return (k[1] * x + b[1]);
            }
        }
    }
}