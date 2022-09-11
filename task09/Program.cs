// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа 

int num = new Random().Next( 10, 100 );
// int firstDigit = num / 10; //7
// int secondDigit = num % 10; //8
// if (firstDigit == secondDigit) Console.WriteLine($"Цифры равны");
// else 
// {
//     if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа [{num} -> {firstDigit}");
//     else Console.WriteLine($"Наибольшая цифрв числа {num} -> {secondDigit}");
// }

int MaxDigit(int num1)
{
    int firstDigit = num1 / 10; //7
    int secondDigit = num1 % 10; //8
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

int maxDigit = MaxDigit(num);
string result = maxDigit > 0 ? maxDigit.ToString(): "Цифры равны";
Console.WriteLine($"Наибольшая цифрв числа {num} -> {maxDigit}");