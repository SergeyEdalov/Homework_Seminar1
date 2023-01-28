// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter your count: ");
int count = Convert.ToInt32(Console.ReadLine());

if (count % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}