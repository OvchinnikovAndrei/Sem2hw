// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи число: ");
int day = int.Parse(Console.ReadLine()!);

void CheckWeekendDay (int day) 
{
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("Выходной день");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("Нет такого дня недели");
  }
  else Console.WriteLine("Будний день");
}

CheckWeekendDay(day);