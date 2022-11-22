// int[] array = new int[8];
//  0   1   2   3   4   5   6   7
//  0, 0, 0, 0, 0, 0, 0, 0
// int[] array2 = new int[5] { 4, 6, 7, 9, 0 };
// int[] array1 = {1,4,5,5,8};

// array[0] = 345;
// array[1] = 44;
// array[6] = 87;
// array[6] = 87;
// array[9] = 87;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

FillArray(array);
PrintArray(array);






