Console.Clear();

Console.WriteLine("Введите любое положительное число больше 1: ");
int number = int.Parse(Console.ReadLine()!);

int count = 2;

if(number <= 1)
    {
        Console.WriteLine("Введенное число не соответствует условию");
    }
else
{
    while(count <= number)
    {
        Console.Write($"{count}, ");
        count+=2;
    }
}