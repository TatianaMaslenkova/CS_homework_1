// Посмотрела 2-ю лекцию перед тем, как сделать ДЗ 1. Пробовала решить через метод и массивы.
Console.Clear();

int max(int arg1, int arg2, int arg3)  //вводим метод (функцию)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);

int maximum = max(number1, number2, number3);    //обращаемся к методу (функции)
Console.Write($"Максимальное из трёх чисел: {maximum}");

// Второй способ (тоже проверяла) через массивы, (тоже из 2-й лекции):
// Console.Clear();

// Console.WriteLine("Введите три числа через пробел: ");

// string[] arr = Console.ReadLine()!.Split(' ');

// int number1 = int.Parse(arr[0]);
// int number2 = int.Parse(arr[1]);
// int number3 = int.Parse(arr[2]);

// if(number1 >= number2 & number1 >= number3)
// {
//     Console.WriteLine($"Максимальное из трёх чисел: {number1}");
// }
// else if(number2 >= number1 & number2 >= number3)
// {
//     Console.WriteLine($"Максимальное из трёх чисел: {number2}");
// }
// else if(number3 >= number1 & number3 >= number2)
// {
//     Console.WriteLine($"Максимальное из трёх чисел: {number3}");
// }

// Третий способ, который тоже проверяла (без ввода метода и без массива):
// int maximum = Math.Max(number1, Math.Max(number2, number3));
// Console.Write($"Максимальное из трёх чисел: {maximum}");