﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetPower (int num1, int num2)
{
    if (num2 ==0)
    return 1;
    if (num2 == 1)
    return num1;

    return num1 * GetPower(num1, num2-1);
}

int power = GetPower(number1, number2);
Console.WriteLine ($"Число {number1} в степени {number2} = {power}");
