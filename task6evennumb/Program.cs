Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()?? "0");
if(number1 % 2 == 0)
  {
        Console.WriteLine("Число " + number1 + " чётное");
    }
  else
  {
        Console.WriteLine("Число " + number1 + " нечётное");
    }
