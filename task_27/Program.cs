// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_27
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

            // Создаем метод разбиения числа на отдельные элементы и вычисления их суммы
            int ResultSum(int number)
            {
                int result = 0;
                int remains;
                do
                {
                    remains = number % 10;
                    result += remains;
                    number /= 10;
                } while (number > 0);
                return result;
            }

            // Основной блок
            int userNumber = ConvertUserMassedge("Введите число: ");
            int sumDigit = ResultSum(userNumber);
            Console.WriteLine($"Сумма цифр в числе {userNumber} равна {sumDigit}");
        }
    }
}
