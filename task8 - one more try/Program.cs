﻿// Задача 8: Напишите программу, которая на вход 
//принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите любое число:   ");
int a=Convert.ToInt32(Console.ReadLine());
int x=1;

if (a==2 || a==0)
{
    Console.WriteLine("К сожалению, между 1 и " +a+ " четных чисел не нашлось");
}
else
{
    for (x = 1; x < a; x++)
    {
       if (x % 2 ==0)
       {
          Console.Write(x+", ");
       }               
    }
    for (x = 1; x > a; x--)
        {
       if (x % 2 ==0)
       {
          Console.Write(x+", ");
       }               
    }
}