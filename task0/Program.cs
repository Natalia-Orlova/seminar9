// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

PrintNaturalNum(num1, num2);
void PrintNaturalNum(int m1, int n1)
{
    Console.Write($"{m1}, ");
    if (m1 > n1)
    PrintNaturalNum(m1-1,n1);

    else if (m1 < n1)
    PrintNaturalNum(m1+1,n1);
}

