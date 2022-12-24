


void InputMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine($"Ведите значение для {i}; {j} элемента");
            matrix[i, j] = Console.ReadLine();
        }
    }
}

void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Medium(string[,] img,string[,] negatif)
{
    int error=0;
    for (int i = 0; i < img.GetLength(0); i++)
    {
        for (int j = 0; j < img.GetLength(1); j++)
        {
            if(negatif[i,j]==img[i,j])
            error++;
        }
    }
    Console.WriteLine($"Количество ошибок равно: {error}");
}

Console.Clear();
Console.WriteLine("Ведите размерность массива:");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
string[,] img = new string[s[0], s[1]];
string[,] negatif = new string[s[0], s[1]];
InputMatrix(img);
InputMatrix(negatif);
Console.WriteLine("Изображение:");
PrintMatrix(img);
Console.WriteLine("Негатив:");
PrintMatrix(negatif);
Medium(img, negatif);