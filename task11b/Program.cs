void InputMatrix(int[,] matrix)
{
    int c=1;
    int x=0;
    int j = 0;
    for (int i = 0; i <= matrix.GetLength(0); i++)
    {
        while(j<matrix.GetLength(1))
        {
            x=j;
            for (i = 0; i <= x; i++)
            {
                matrix[i, j] = c;
               c++;
             j=j-1;
        }
        j=x;
        j++;
        }
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

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");

InputMatrix(matrix);
PrintMatrix(matrix);
