//Напишите программу, которая принимает на вход три числа
//и выдает максимальное из этих чисел.
Console.Clear();

Console.Write("Введите число1: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число2: ");

int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите число3: ");

int number3 = int.Parse(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
              Console.WriteLine("max = " + number1);
} 
else if (number2 > number1 && number2 > number3)
{
              Console.WriteLine("max = " + number2);
}
else 
{
              Console.WriteLine("max = " + number3);
}