Console.Clear();

Console.WriteLine("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));

if(number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}