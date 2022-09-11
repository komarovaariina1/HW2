Console.Clear();
Console.WriteLine("Привет, пользователь! Введи первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Отлично! Продолжай, введи второ число");
int num2 = Convert.ToInt32(Console.ReadLine());
int kako = num1 % num2;

if(num1 > num2){
    if(kako == 0){
        Console.WriteLine($"{num2} кратно {num1}");
    }
    else{
        Console.WriteLine($"{num2} не кратен {num1}, остаток = {kako}");

    }
    Console.WriteLine("Введите другие числа");
}
