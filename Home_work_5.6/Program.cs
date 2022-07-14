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

            // !!! В данный код добавил проверку на корректность ввода значений (строки: 19 и 32). Пример: когда значение не вводится а сразу нажимается "Enter"
            // Если нужно проверить только основную логику кода, используйте коммит - git checkout 212c28b

            Console.Write("Введите количество вводимых чисел: ");
            string M = Console.ReadLine();
            if (M.Length > 0)                           // Проверка на введение начального параметра - "количество вводимых значений"
            {
                int[] array = new int[Convert.ToInt32(M)];
                int count = 0, aboveZero = 0;
                FillArray(array);
                Console.WriteLine($"В массиве [{String.Join("; ", array)}] элементов являющихся > 0 - {AboveZero(array)}");

                void FillArray(int[] arrayInFunction)   // Функция ввода элементов в массив с помощью рекурсивного метода
                {
                    if (count < arrayInFunction.Length) // условие выполнения рекурсии
                    {
                        Console.Write($"Введите элемент массива под номером {count} (введите целое число, меньше или больше '0'!): ");
                        string checkEnter = Console.ReadLine();
                        if (checkEnter.Length > 0)      // Проверяем, ввели ли значение?
                            arrayInFunction[count] = Convert.ToInt32(checkEnter);
                        else
                            arrayInFunction[count] = 0; // Если не ввели, то данному элементу массива присваиваем - "0"
                        count++;
                        FillArray(arrayInFunction);
                    }
                    count = 0;
                }

                int AboveZero(int[] arrayInFunction)
                {
                    if (count < arrayInFunction.Length) // условие выполнения рекурсии
                    {
                        if (arrayInFunction[count] > 0)
                            aboveZero++;
                        count++;
                        AboveZero(array);
                    }
                    return (aboveZero);
                }
            }
            else
            {
                Console.WriteLine("Ошибочный ввод! Неверно задано количество вводимых значений. Программа завершает свою работу!");
                return;
            }
        }
    }
}