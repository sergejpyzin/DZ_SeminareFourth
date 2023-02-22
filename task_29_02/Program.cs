//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_29_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем метод запроса информации у пользователя;
            int ConvertUserMassedge(string userMassedge)
            {
                int number;
                while (true)
                {
                    Console.Write(userMassedge);
                    bool convertUserMassadge = int.TryParse(Console.ReadLine(), out number);
                    if (convertUserMassadge) return number;
                    else Console.WriteLine("Ошибка! Введенные данные некоректны. Попробуйте еще раз.");

                }
            }

            // Создаем метод заполнения массива
            int[] FillingArray(int length)
            {
                int[] array = new int[length];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = ConvertUserMassedge("Введите элемент массива: ");
                }
                return array;
            }

            // Создаем метод вывода массива на печать
            void PrintArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length - 1; i++)
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.Write($"{array.Length}");
                Console.WriteLine($"]");
            }

            // Основной блок
            int arrayLength = ConvertUserMassedge("Введите необходимую длинну массива: ");
            int[] arr = FillingArray(arrayLength);
            PrintArray(arr);
        }
    }
}
