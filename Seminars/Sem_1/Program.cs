
// Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(a * a);

// // Напишите программу, которая 
// на вход принимает 
// два целых числа и проверяет, 
// является ли первое число квадратом 
// второго.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     System.Console.WriteLine($"{num1} is quad of {num2}");
// }
// else
// {
//     System.Console.WriteLine($"{num1} is not quad of {num2}");
// }

// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все 
// целые числа в промежутке от -N до N.

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = -n;
// while(start <= n)
// {
//     System.Console.Write(start + " ");
//     start ++;
// }

// Напишите программу, которая принимает на вход 
// трёхзначное целое число и на выходе 
// показывает сумму первой и последней 
// цифры этого числа.

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num <= 999)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine($"Sum of {ed} and {sot} -> {ed + sot}");
// }
// else
// System.Console.WriteLine("You input not three-digit number");