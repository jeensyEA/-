// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введи день недели(цифрой): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
CheckingTheDayOfTheWeek(dayNumber);
void CheckingTheDayOfTheWeek (int dayNumber)

{
  if (dayNumber == 6 || dayNumber == 7)
  {
  Console.WriteLine("да");
  }
    else if (dayNumber < 1 || dayNumber > 7)
   {
    Console.WriteLine("это не день недели");
   }
  else
  {
  Console.WriteLine("нет");
  }
}

