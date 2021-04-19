using System;
using System.IO;

namespace HomeWork4._4
{
    // Суханов 
    // Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    // Создайте структуру Account, содержащую Login и Password.

    struct Account // Создал структуру. Это требовалось или нет, не знаю... 
    {
        public static bool LogPas() // Дал возможность пользователю вводить название файла, в котором хранятся логин и пароль. 
        {
            Console.Write("Введите название файла для ввода логина и пароля: "); // Просил вводить только название. Формат файла добавил сам. 
            string a = Console.ReadLine() + ".txt";
            do
            {
                if (File.Exists(a)) break;
                Console.WriteLine("Такого файла не существует. Введите существующий: ");
                a = Console.ReadLine() + ".txt";
            } while (!File.Exists(a));
            int i = 0;
            int length = File.ReadAllLines(a).Length;
            string[] arr = new string[length];
            string[] acc = File.ReadAllLines(a);
            foreach (var elem in acc)
            {
                arr[i] = elem;
                i++;
            }
            return (arr[0] == "root" && arr[1] == "GeekBrains");
        }
        public static void Try()
        {
            int tr = 3;
            do
            {
                if (LogPas() == true)
                {
                    Console.WriteLine("Авторизация прошла упешно.");
                    break;
                }
                else
                {
                    tr--;
                    Console.WriteLine($"Неверный логин или пароль. Осталось попыток {tr}.");
                }
            } while (tr != 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // File.WriteAllText("Account.txt", "root\nGeekBrains");   // Создал документ с логином и паролем
            // File.WriteAllText("NewAccount.txt", "rt\nGeekBrains");  // Создал документ с неверным логином и паролем
            // File.WriteAllText("WrongAccount.txt", "rt\nGeekains");  // Создал документ с неверным логином и паролем 

            Account.Try();
        }
    }
}
