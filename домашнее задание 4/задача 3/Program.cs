// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
namespace Abcd
{
    class Program
    {
      
        static void Main()
        {
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            string[] strs = new string[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива №{0}:\r\n  ", i + 1);
                strs[i] = Console.ReadLine(); 
            }
            Console.WriteLine("Вы ввели следующие элементы массиваи:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strs[i]);
            }
  
            Console.ReadLine();
        }
    }
}