using System;

namespace Home_work_5._6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // ДЗ к теме урока: "Двумерные массивы и рекурсия"
            // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            // 0, 7, 8, -2, -2-> 2
            // 1, -7, 567, 89, 223-> 3
            Console.Write("Введите количество вводимых чисел: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[M];
            int count = 0;
            FillArray(array);
            Console.WriteLine($"[{String.Join(";", array)}]");  // Проверка заполненности массива

            void FillArray(int[] arrayInFunction)  // Функция ввода элементов в массив с помощью рекурсивного метода
            {
                if (count < arrayInFunction.Length) // условие выхода из рекурсии
                {
                    Console.Write($"Введите элемент массива под номером {count} (введите целое число, меньше или больше '0'!): ");
                    arrayInFunction[count] = Convert.ToInt32(Console.ReadLine());
                    count++;
                    FillArray(arrayInFunction);
                }
                count = 0;
            }
        }
    }
}