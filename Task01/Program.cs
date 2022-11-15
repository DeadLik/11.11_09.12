int MinusMidlle(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 100;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int number1 = MinusMidlle(number);

Console.WriteLine(number1);