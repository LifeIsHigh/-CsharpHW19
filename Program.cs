// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Enter a value m: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value n: ");
int Columns = Convert.ToInt32(Console.ReadLine());
double[,] Matrix = new double[Rows, Columns];

for (int i = 0; i < Rows; i++)
{
    for (int j = 0; j < Columns; j++)
    {
        int Temp = new Random().Next(0, 10);
        Matrix[i,j] = Math.Round(new Random().NextDouble() * Temp, 2);
        Console.Write ($"{Matrix[i,j]} ");
    }
    Console.WriteLine();
}