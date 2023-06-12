// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int index = 2;
while (index <= number)
{
    System.Console.Write(index + " ");
    index +=2;
}