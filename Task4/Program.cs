//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до N.

Console.Clear();

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

for (int a = 2; a <= number ; a++)
{
              if (a%2 == 0)
              {
                            Console.Write(a + " ");
              } 
} 
           