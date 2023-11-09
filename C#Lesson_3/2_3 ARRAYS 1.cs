﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_ARRAYS_1
{
    internal class Program
    {

        static void PrintArr(string text, int[] arr)  
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write($"{arr[i]}  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {


            //------------------------------------------------------
            //Для самостоятельного рассмотрения
            //------------------------------------------------------

#if true

            //-------------------------------------------------------------
            // Генерация случайных чисел:

            Console.WriteLine("\n---------------------Генерация случайных чисел------------------");

            Random random = new Random();

            // Генерируем случайное целое число в диапазоне от 5 до 10
            int randomInt = random.Next(5, 10);
            Console.WriteLine("Случайное целое число: " + randomInt);

            // Генерируем случайное дробное число в диапазоне от 0.0 до 1.0
            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble);

            // Масштабируем это число до нужного диапазона
            double minValue = 5.0; // Нижний предел диапазона
            double maxValue = 10.0; // Верхний предел диапазона
            double result = (maxValue - minValue) * randomDouble + minValue;

            Console.WriteLine($"Случайное дробное число в диапазоне от " +
                $"{minValue} до {maxValue}: {result}");

#endif

#if true


            Console.WriteLine("\n------------некоторые методы класса ARRAY------------------------");

            int[] arr = { 25, 6, -9, 78, 4, 32, -5, 18, -6, 25, -13, 25, 14, 6 };

            // PrintArr - пользоватльский метод для вывода массива на экран
            // (в целях неповторяемости кода)
            PrintArr("Массив arr: ", arr);


            // Reverse
            Array.Reverse(arr);
            //Array.Reverse(arr1, 2, 5);// с какого индекса и какое количество элементов реверсировать
            PrintArr("\nМассив arr1 после реверсирования", arr);

         
            // Resize
            // Ключевое слово ref при передаче массива в функцию,
            // чтобы не создавалась копия ссылки и отработало перераспределение памяти
            Array.Resize(ref arr, 20);  
            PrintArr("\nМассив arr1 после изменения размера:", arr);

            // Методы для поиска по условию: Find   FindLast  FindAll  и метод  IndexOf
            
            // Find

            int res = Array.Find(arr, x => x < 0);
            Console.WriteLine("Первое отрицательное значение в массиве: {0} ", res);
            Console.WriteLine("Индекс значения: {0}", Array.IndexOf(arr, res));

            // Find - если не находит значение по условию,
            // возвращает значение по умолчанию для этого типа
            int value = 100;
            res = Array.Find(arr, x => x > value);
            Console.WriteLine("Первое значение > 100: {0} ", res);

            res = Array.FindLast(arr, i => i > 0);
            Console.WriteLine("\nПоследнее положительное число в массиве: " + res);


            //FindAll
            int[] mas_even = Array.FindAll(arr, (x) => x % 2 == 0);
            PrintArr("\nМассив четных значений:", mas_even);
            Console.WriteLine("Размер массива: {0}", mas_even.Length);

            // Clear
            // Очищение с какого индекса и сколько элементов
            Array.Clear(arr, 3, 5);                       
            PrintArr("\nМассив arr после очищения(частичного): ", arr); //6  14  25  0  0  0  0  0  32  4  78 - 9  6  25  0
            Console.WriteLine("Размер массива: {0}", mas_even.Length);
            Array.Clear(arr, 0, arr.Length);
            PrintArr("\nМассив arr1 после очищения(всех данных): ", arr);// нулевые значения



            // BinarySearch - двоичный поиск в отсортированном по ВОЗРАСТНИЮ массиве

            int[] arr2 = { 25, 6, -9, 78, 4, 32, -5, 18, -6, 25, -13, 25, 14, 6 };
            Array.Sort(arr2);
            PrintArr("Массив arr2 после сортировки: ", arr2);

            int n = 25;
            int r = Array.BinarySearch(arr2, n);
            if (res >= 0)
            {
                Console.WriteLine("Число " + n + " находится в массиве на " +
                   r + " позиции");
            }
            else
            {
                Console.WriteLine("\nЗначения в массиве нет");
            }

#endif

#if true

            Console.WriteLine("\n----------некоторые методы расширения----------------------\n");

            // Contains Max   Min   Average   Count  
            // using System.Linq;  

            int[] arr3 = { 25, 6, -9, 78, 4, 32, -5, 18, -6, 25, -13, 25, 14, 6 };
            PrintArr("\nМассив 'arr3' ", arr3);

            int v = 78;
            if (arr3.Contains(v))
            {
                Console.WriteLine($"Значение {v} есть в массиве");
            }
            else
            {
                Console.WriteLine($"Значение {v} не найдено");
            }

            Console.WriteLine("\nМаксимальный элемент в массиве arr1: " + arr3.Max());

            Console.WriteLine("\nМинимальный элемент в массиве arr1: " + arr3.Min());

            Console.WriteLine("\nСреднее арифметическое элементов arr1: " + arr3.Average());
            Console.WriteLine("\nСумма элементов arr1: " + arr3.Sum());

           
            Console.WriteLine("\nКоличество четных элементов массива: {0}", arr3.Count(x => x % 2 == 0));
            Console.WriteLine("\nКоличество отрицательных элементов массива: {0}", arr3.Count(x => x < 0));

            // Дополнительно: Посчитать количество уникальных значений в массиве
            int[] mas = { 10, 2, 2, 3, 4, 4, 5, 6, 10, 10 };
            PrintArr("Исходный массив", mas);

            int count2 = mas.Distinct().Count();
            Console.WriteLine(mas.Distinct().GetType());

            Console.WriteLine($"Количество уникальных элементов: {count2}");

            // Дополнительно: Получить массив уникальных значений на основе исходного
            int[] uniq = mas.Distinct().ToArray();

            PrintArr("Массив ункальных значений", uniq);

#endif
            Console.ReadLine();
        }
    }
}






//----------------------------------------------------------------
/*
 * Некоторые методы класса Array:
        - GetLength возвращает количество элементов массива
          по заданному измерению.

        - GetLowerBound и GetUpperBound возвращают соответственно нижнюю и верхнюю границы 
          массива по заданному измерению (например, если есть одномерный
          массив на 5 элементов, то нижняя граница будет «0», верхняя — «4»).

        - CopyTo копирует все элементы одного одномерного
          массива в другой, начиная с заданной позиции целевого массива.

        - Clone производит поверхностное копирование массива. 
          Копия возвращается в виде массива System.Object[].

        - Статический метод BinarySearch производит бинарный
          поиск значения в массиве (в диапазоне массива).

        - Статический метод Clear присваивает значения по
          умолчанию типа элемента каждого элемента в массиве.

        - Статический метод IndexOf — возвращает индекс первого вхождения искомого элемента в массиве, 
          в случае неудачи — возвращает «–1». Поиск производится от  начала массива.

        - Статический метод LastIndexOf — возвращает индекс
          первого вхождения искомого элемента в массиве. Поиск
          производится с конца массива, в случае неудачи —
          возвращает «–1».

        - Статический метод Resize изменяет размер массива.

        - Статический метод Reverse — реверсирует массив (диапазон массива).

        - Статический метод Sort — сортирует массив (диапазон  массива).

    Также присутствуют методы расширения:

        - Sum — суммирует элементы массива.

        - Average — подсчитывает среднее арифметическое элементов массива.

        - Contains — возвращает истину, если заданный элемент присутствует в массиве.

        - Max — возвращает максимальный элемент массива.

        - Min — возвращает минимальный элемент массива.
        
    И пара свойств:
        - Свойство Length — возвращает длину массива.
        - Свойство Rank — возвращает количество измерений массива.

*/

