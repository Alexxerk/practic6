//Последовательная сумма индексов.

int[,] matrix = new int[6, 6];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
        Console.Write(matrix[i, j] + " ");
    }
Console.WriteLine();
}