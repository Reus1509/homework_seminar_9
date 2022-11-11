// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
void Main()
{
    Console.Clear();
    Console.Write("Введите число 1: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите число 2: ");
    int number2 = int.Parse(Console.ReadLine());
    if (number1 < 0 || number2 < 0) Console.WriteLine("Введено отрицательое число!");
    int result = AkkFunc(number1, number2);
    Console.WriteLine($"Результат равен: {result}.");
}

int AkkFunc(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number1 != 0 && number2 == 0) return AkkFunc(number1 - 1, 1);
    if (number1 > 0 && number2 > 0) return AkkFunc(number1 - 1, AkkFunc(number1, number2 - 1));
    return AkkFunc(number1, number2);
}

Main();