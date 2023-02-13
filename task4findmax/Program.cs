Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine() ?? "0");
if(number1>number2)
{
    if(number1>number3)
    {  Console.WriteLine("Максимальное число равно: " + number1);
    }
    else
    {
        Console.WriteLine("Максимальное число равно: " + number3);
    }
}
else
{
    if(number2>number3)
    {  Console.WriteLine("Максимальное число равно: " + number1);
    }
    else
    {
        Console.WriteLine("Максимальное число равно: " + number3);
    }
}
