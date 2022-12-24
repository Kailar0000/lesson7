void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Medium(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int medium = 0 , sum= 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum=sum+matrix[i,j];
    }
    medium =sum/matrix.GetLength(0);
    Console.WriteLine($"Столбец: {j+1} Средниие: {medium}");
    }
}

Console.Clear();
int sizex = new Random().Next(1, 11);
int sizey = new Random().Next(1, 11);
int[,] matrix = new int[sizex, sizey];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Medium(matrix);