void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите коардинаты элемента: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int sizex = new Random().Next(1, 11);
int sizey = new Random().Next(1, 11);
int[,] matrix = new int[sizex, sizey];
InputMatrix(matrix);
while(size[0]>=matrix.GetLength(0) || size[1]>=matrix.GetLength(1))
{
    Console.Write($"Ошибка. Ведите коардинаты в приделах {matrix.GetLength(0)} и {matrix.GetLength(1)}: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
Console.WriteLine($"Элемент матрици равен: {matrix[size[0]-1,size[1]-1]}");