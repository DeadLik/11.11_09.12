// 22. Напишите программу, которая
// 1. принимает на вход число (N) и выдаёт таблицу
// 2. квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int numb)
{
    int count = 1;
    while (count <= numb)
    {
        Console.WriteLine($"{count}  {count*count}");
        count++;
    }
}

if(number > 0) Square(number);
else Console.WriteLine("Число не является натуральным");