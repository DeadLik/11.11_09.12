// 17. Напишите программу, которая 
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и 
// 3. выдаёт номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int Quarter(int xc, int yc)
// {
//     if(xc > 0 && yc > 0) return 1;
//     if(xc < 0 && yc > 0) return 2;
//     if(xc < 0 && yc < 0) return 3;
//     if(xc > 0 && yc < 0) return 4;
//     return 0;
// }

// int quarter = Quarter(x, y);
// string result = quarter > 0 
//         ? $"Указанные координаты соответствуют четверти -> {quarter}"
//         : "Введены некорректные координаты";

// Console.WriteLine(result);

// ------------------------------------------------------------------------

// 18. Напишите программу, 
// 1. которая по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек 
// 3. в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
string number = Console.ReadLine();

string Range(string num)
{
    if (num == "1") return "X > 0 и Y > 0";
    if (num == "2") return "X < 0 и Y > 0";
    if (num == "3") return "X < 0 и Y < 0";
    if (num == "4") return "X > 0 и Y < 0";
    return "Введены некорректные данные";
}
string result = Range(number);
Console.WriteLine(result);
