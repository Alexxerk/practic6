//Задаем двумерный массив вещественных чисел.

double[,] matr = new double[4, 3];

Random random = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matr[i, j] = random.Next(-100, 100) + random.NextDouble();
        Console.Write("{0,6:F2} ", matr[i, j]);
    }
    Console.WriteLine();
}







