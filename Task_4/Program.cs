// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter your number: ");
int i = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a < i+1; a++)
{
    if (a % 2 == 0) 
    {
        Console.Write($"{a}, ");
    }
}