// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите два числа число:");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int PowerNumber(int numM, int numN)
{
    if (numN == 0) return 1;
    return numM * PowerNumber(numM, numN - 1);
}

int res = PowerNumber(m, n);
Console.WriteLine(res);