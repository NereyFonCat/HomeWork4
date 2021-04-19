using System;
using System.IO;

namespace HomeWork4._2
{
    // Суханов
    // Реализуйте задачу 1 в виде статического класса StaticClass;
    // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;

    static class StaticClass
    {
        public static void MyQuest(int n, int min, int max) // Надеюсь, правильно понял, как нужно сделать данное задание... 
        {
            int i;
            int[] a;
            a = new int[n];
            for (i = 0; i < n; i++)  
            {
                Random rn = new Random();
                a[i] = rn.Next(min, max);
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            int c = 0;
            for (i = 0; i < 19; i++)
            {
                if (a[i] % 3 == 0 ^ a[i + 1] % 3 == 0)
                {
                    c++;
                }
            }
            Console.WriteLine($"В массиве всего {c} пар случайных чисел, среди которых только одно число кратно трём.");
        }

        // б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
        // в)* Добавьте обработку ситуации отсутствия файла на диске.
        public static void Text() // Дал выбор файла пользователю
        {
            string a;
            Console.Write("Введите название файла, который нужно сконвертировать в массив целых чисел: "); // В папке сохранил файл с названием HomeWorkk
            a = Console.ReadLine() + ".txt"; // Упростил для пользователя ввод названия файла, чтобы тот ввёл только наименование без формата
            if (File.Exists(a)) // Тут же ввёл проверку на наличие файла
            {
                int i = 0;
                int length = File.ReadAllLines(a).Length;
                int[] arr = new int[length];
                string[] elems = File.ReadAllLines(a);
                foreach (var elem in elems)
                {
                    arr[i] = int.Parse(elem);
                    Console.WriteLine(arr[i]);
                    i++;
                }
            }
            else Console.WriteLine("Файл с таким названием отсутствует на диске");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.MyQuest(20, -10000, 10000); // Ссылка на статический класс с методом решения первой задачи 
            StaticClass.Text(); // Ссылка на метод вывода целых чисел в массив из текстового файла 
        }
    }
}
