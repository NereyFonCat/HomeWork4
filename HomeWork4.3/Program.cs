﻿using System;
using System.Collections.Generic;

namespace HomeWork4._3
{
    // Суханов 

    // б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки

    // Не знаю, как реализовать библиотеку с классом для работы с массивом. Пробовал создать библиотеку с классом для одномерного массива,
    // Добавил в зависимость к одному проекту, ничего не работает. 

    // в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int, int>)
    // С этим также не разобрался, вообще не могу понять...( 


    // а) Дописать класс для работы с одномерным массивом.
    class Array
    {
        // Суханов 
        int i = 0;
        int[] a;

        // Реализовать конструктор, создающий массив определенного размера
        // и заполняющий массив числами от начального значения с заданным шагом.
        public Array(int n, int el, int walk)             //  Создание массива и заполнение его числами от значения el с шагом в walk
        {
            a = new int[n];
            for (i = 0; i < n; i++)
            {
                a[i] = el;
                el = el + walk;
            }
        }
        public void Print() // Для вывода массива, на всякий случай 
        {
            for (i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }

        // Создать свойство Sum, которое возвращает сумму элементов массива
        public int Sum
        {
            get
            {
                int sum = 0;
                for (i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];
                }
                return sum;
            }
        }
        public Array(int[] a)
        {
            this.a = a;
        }
        // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
        public Array Inverse()
        {
            int[] b = new int[a.Length];
            for (i = 0; i < a.Length; i++)
            {
                b[i] = -a[i];
            }
            return new Array(b);
        }
        // метод Multi, умножающий каждый элемент массива на определённое число,
        public Array Multi(int mnozh)
        {
            int[] b = new int[a.Length];
            for (i = 0; i < a.Length; i++)
            {
                b[i] = a[i] * mnozh;
            }
            return new Array(b);
        }
        // свойство MaxCount, возвращающее количество максимальных элементов.
        public int MaxCount
        {
            get
            {
                int max = 0;
                int count = 0;
                for (i = 1; i < a.Length; i++) // Проверка на максимальный элемент в массиве
                {
                    if (a[i - 1] < a[i])
                    {
                        max = a[i];
                    }
                }
                for (i = 0; i < a.Length; i++) // Подсчёт количества максимальных элементов
                {
                    if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Array arr = new Array(10, 0, 2);
            Array aInv = arr.Inverse();
            Array aMulti = arr.Multi(3);
            arr.Print();
            aInv.Print();
            aMulti.Print();
            Console.WriteLine($"Сумма чисел в основно массиве равна {arr.Sum}");
            Console.WriteLine($"Количество максиальных элементов в основном массиве {arr.MaxCount}"); 
        }
    }
}
