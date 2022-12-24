void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
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

void Transfer(int[,] matrix)
{
    int x=0;
    int temp=0;
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            x=matrix.GetLength(0)-1-i;
            temp = matrix[i,j];
            matrix[i,j]=matrix[x,j];
            matrix[x,j]=temp;
        }
    }
}

Console.Clear();
Console.Write("Введите коардинаты элемента: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
Transfer(matrix);
Console.WriteLine("Измененный массив:");
PrintMatrix(matrix);