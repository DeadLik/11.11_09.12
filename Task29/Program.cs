// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintMatrix1(int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != array[0] && j != array[1])

                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
                else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine(" ");
    }
}


int[] FindIndex(int[,] matrix)
{
    int[] array = new int[2];
    int min = matrix[0, 0];
    int rowIndex = 0;
    int columnIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                rowIndex = i;
                columnIndex = j;
            }
        }
    }
    array[0] = rowIndex;
    array[1] = columnIndex;
    return array;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] arr = FindIndex(array2D);
PrintMatrix1(array2D, arr);


// int[,,] CreateMatrixRndInt1(int rows, int columns, int depth, int min, int max) // Метод создания трёхмерного массива
// {
//     int[,,] matrix = new int[rows, columns, depth]; // 0, 1
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++) //2
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1); // 2- 3
//             }
            
//         }
//     }
//     return matrix;
// }
