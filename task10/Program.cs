// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
//string number = Console.ReadLine()!;
int number = int.Parse(Console.ReadLine()!);
string num = Convert.ToString(number);
if (number > 0)
{
    Console.WriteLine(num[1]);
}
else
{
    Console.WriteLine(num[2]);
}