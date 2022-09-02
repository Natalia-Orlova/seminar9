// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число M: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers(number);

int SumNumbers (int num)
{
    if (num<10)
    return num;
    return num % 10 + SumNumbers(num / 10);
}
Console.WriteLine($"Сумма цифр числа {number} = {sum}");