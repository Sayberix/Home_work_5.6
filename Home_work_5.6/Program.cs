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

            double b1 = 0.0, b2 = 0.0, k1 = 0.0, k2 = 0.0, x = 0.0, y = 0.0;
            Console.Write("Введите значение b1: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение k1: ");
            k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            k2 = Convert.ToInt32(Console.ReadLine());

            if (k1 == k2)        // Проверка, не является ли заданные координаты - одинаковыми или параллельными отрезками
            {
                Console.WriteLine("Заданные координаты являются двумя параллельными прямыми или совпадают! Программа завершает работу!");
                return;
            }

            x = FindX(b1, b2, k1, k2);
            y = FindY(b2, k2, x);

            Console.WriteLine($"Точка пересечения заданных двух прямых по заданным координатам - X = {x}; Y = {y}");

            double FindX(double b1, double b2, double k1, double k2)
            {
                double x = (-b2 + b1) / (-k1 + k2);
                return (x);
            }

            double FindY(double b2, double k2, double x)
            {
                double y = k2 * x + b2;
                return (y);
            }
        }
    }
}