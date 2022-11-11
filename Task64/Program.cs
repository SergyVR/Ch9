// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N"); 
int number = int.Parse(Console.ReadLine()); 
 
void CountNumbers (int number)
{
   
    if (number == 0) return;
    Console.Write($"{number} ,");
    CountNumbers(number - 1);
}

CountNumbers(number);
