//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.WriteLine("Введите количество элементов в i: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов в j: ");
int y = int.Parse(Console.ReadLine());

int [,] array = new int[x, y];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,20);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Kvadrat(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); )
    {
        for (int j = 0; j < matr2.GetLength(1); )
        {
            matr2[i, j] = matr2[i, j] * matr2[i, j];
            j = j + 2;
        }
        i = i + 2;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Kvadrat(array);
PrintArray(array);