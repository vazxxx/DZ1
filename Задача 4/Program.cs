Console.WriteLine ("Введи 3 чесла");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if (number2 > max)
{
  max = number2;
}

if (number3 > max)

{
  max = number3;
}
System.Console.WriteLine(max);
