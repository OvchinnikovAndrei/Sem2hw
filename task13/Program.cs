// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введи число: ");
// int num = int.Parse(Console.ReadLine()!);
// string numText = Convert.ToString(num);

// if (numText.Length > 2)
// {
//     Console.WriteLine(numText[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }




Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);
string numText = Convert.ToString(num);

if (numText.Length > 2 && num > 0)
{
    Console.WriteLine(numText[2]);
}
else if (numText.Length < 3 || (numText.Length < 4 && num < 0))
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(numText[3]);
}