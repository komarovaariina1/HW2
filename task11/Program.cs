// Напишите программу, которая вывод трехзначное число и удаляет вторую цифру этого числа
// 436 -> 46
// 782 -> 72

int number = new Random().Next(100, 1000);

int MaxDigit(int num)
{
    int firstDigit = num / 100 * 10;
    int secondDigit = num % 10;
    return firstDigit = secondDigit;
}
int result = MaxDigit(number);
Console.WriteLine($"{number} -> {result}");
