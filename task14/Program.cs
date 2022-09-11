//  Напишите программу, которая принимает на ввод число и проверяет, крастно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a =7, b =23;
if (num % a == 0 && num % b == 0) {
    Console.WriteLine($"Xbckj {num} rhfnyj {a} и {b}");

}
