﻿
// void NumToQuad (int num)
// {
//     System.Console.WriteLine(num * num);
// }

// int NumToQuadInt (int num)
// {
//     return num * num;
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(NumToQuadInt(a));


// Напишите программу, которая принимает на вход 
// трёхзначное число и удаляет вторую цифру этого числа.

// int DeleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// int SecondToThirPower(int num)
// {
//     if (num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for (int i = 0; i < ed; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not three-digit number");
//         return 0;
//     }
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SecondToThirPower(num));

// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если первое число некратно второму, то программа выводит остаток от деления.


void CheckIfDevides (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2} -> yes");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} -> no, {num1 % num2}");
    }
}

Console.Write ("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num1, num2);