Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
int a = 2;
while (a <= number1)
{
    Console.Write(a);
    a=a+2;
  }

