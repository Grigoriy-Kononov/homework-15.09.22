//Напишите программу, которая на вход принимает два числа
//и выдает, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите число1: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число2: ");

int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
              Console.WriteLine(number1 +  " > " + number2);
} 
else
{
              Console.WriteLine((number2 +  " > " + number1));
}