// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n)
{
    if (n == 0) return 0;
    else
        return n % 10 + SumNumbers(n / 10);
}

int res = SumNumbers(Math.Abs(number));
Console.WriteLine(res);

