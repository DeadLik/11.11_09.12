Console.WriteLine("Введите 2 числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int number1, int number2) {
    return number1 % number2;
}

int res = Multiplicity(num1, num2);
if(res == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно {res}");
