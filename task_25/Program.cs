using System;

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16



namespace task_25
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

            // Создаем метод проверки степени на натуральность числа
            bool NaturalExponent(int naturalExponent)
            {
                if (naturalExponent > 0) return true;
                else return false;
            }

            // Создаем метод получения натуральной степени числа
            int NaturalDegree(int basisNaturalDegree, int exponentNaturalDegree)
            {
                int result = 1;
                for (int i = 0; i < exponentNaturalDegree; i++) result *= basisNaturalDegree;
                return result;             
            }

            // Основной блок 
            int basis = ConvertUserMassedge ("Введите основание (число A): ");
            int exponent = ConvertUserMassedge ("Введите степень (число В): ");

            int naturalDegrees = NaturalDegree(basis, exponent);

            if (NaturalExponent(exponent)) Console.WriteLine($"Результат возведение числа {basis} в степень {exponent} равен {naturalDegrees}");
            else Console.WriteLine("Степень числа должна быть натуральной, т.е. больше нуля");
        }
    }
}
