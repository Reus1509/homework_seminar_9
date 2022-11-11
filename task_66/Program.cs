// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void Main()
{
    Console.Clear();
    Console.Write("Введите число 1: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = int.Parse(Console.ReadLine());
    int sum = FindIntervalSum(number1, number2);
    Console.Write($"Результат равен: {sum}.");
}

int FindIntervalSum(int number1, int number2)
{   
    int sum = 0;
    if(number1 == number2) return number1;
    return sum = number1 + FindIntervalSum(number1 + 1, number2);
}

Main();