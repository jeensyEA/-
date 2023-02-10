// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1





Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 1)
{
  Console.WriteLine("вторая цифра -> " + anyNumberText[1]);
}
else
{
  Console.WriteLine("второй цифры нет");
}