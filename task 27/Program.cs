// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

System.Console.Write("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (num > 0 || num < 0) {
    result += num % 10;
    num = num / 10;
}
System.Console.Write($"Сумма цифр числа: {result}");