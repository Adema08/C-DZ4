﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.Write("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for (int i = 1; i <= B; i++) {
    C = C * A;
}
System.Console.Write($"{C}");
