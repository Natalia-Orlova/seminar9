// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers (int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}

NaturalNumbers(number);


// int[,] CreateMatrixRndInt(int row, int col, int min, int max)
// {
//     int[,] matrix = new int[row, col];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
//             else Console.Write($"{matrix[i, j],3} ");
//         }
//         Console.WriteLine("]");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(5, 3, 0, 9);
// PrintMatrix(array2D);
// Console.WriteLine();
