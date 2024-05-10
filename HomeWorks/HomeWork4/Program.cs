// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.
// using System;
// class Program
// {   
//     static void Main()
//     {
//         while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine(); // Чтение строки ввода пользователя
        
//             if (input == "q") // Проверка на ввод 'q' для выхода
//             {
//                 break;
//             }
        
//             int number;
//             if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
//             {
//                 int sum = 0;
//                 while (number > 0) // Вычисление суммы цифр числа 
//                 {
//                     sum += number % 10; // Добавление последней цифры к сумме
//                     number /= 10; // Удаление последней цифры из числа 
//                 }
//                 if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//                 {
//                     Console.WriteLine("[STOP]");
//                     break;
//                 }
//             }
//             else // Если ввод не является числом и не 'q', повторить запрос
//             {
//                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
//             }
//         }
//     }
// }

// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] CreateArray(int size, int min, int max)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next (min, max);
//     }
//     return array;
// }

// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array [i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int ParityCheck(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array [i] % 2 == 0) count ++;
//     }
//     return count;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of arr element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of arr element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateArray(size, min, max);
// PrintArray(array);
// System.Console.WriteLine(ParityCheck(array));


//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int [] CreateArray(int size, int min, int max)
{
     int [] array = new int [size];
     for (int i = 0; i < size; i++)
     {
         array [i] = new Random().Next (min, max);
     }
     return array;
}

int [] ReversArray(int [] array)
{
    int i = 0;
    int temp = array[i];
    for (i = 0; i < array.Length/2; i++)
    {
        temp = array [i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array [i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);
PrintArray(ReversArray(array));

