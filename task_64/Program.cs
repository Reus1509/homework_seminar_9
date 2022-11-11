// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    WriteNums(number);
}

void WriteNums(int number)
{   
    if (number % 2 == 0) Console.Write($"{number} ");
    if (number > 1) WriteNums(number - 1);
}

Main();