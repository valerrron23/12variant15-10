using System;
 
namespace ConsoleApplication35
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите трехзначное число"); //программа просит пользователя ввести переменную вещественного типа
            int x = int.Parse(Console.ReadLine()); //в программу введены данные
            int result = (x%100)*10 + x/100; //программа вычисляет по формуле
            Console.WriteLine("Полученное трехзначное число: {0}", result); //вывод данных
        }
    }
}