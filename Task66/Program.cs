﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M от которого считать"); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число N до которого считать"); 
int n = int.Parse(Console.ReadLine()); 


void GapNumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N (включительно) = {sum}"); 
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}

GapNumberSum(m, n, 0);