Console.Clear();

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if(number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else
{
    int min = Math.Min(number1, number2);
    int max = Math.Max(number1, number2);
    
    Console.WriteLine($"Min = {min}, Max = {max}");
}