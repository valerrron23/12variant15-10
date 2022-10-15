using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения\nВершины А - x1 = "); //программа просит пользователя ввести данные
            double x1 = double.Parse(Console.ReadLine()); //в программу введены данные
            Console.Write("y1 = "); //программа просит пользователя ввести данные
            double y1 = double.Parse(Console.ReadLine()); //в программу введены данные
            Console.Write("Вершины B - x2 = "); //программа просит пользователя ввести данные
            double x2 = double.Parse(Console.ReadLine()); //в программу введены данные
            Console.Write("y2 = "); //программа просит пользователя ввести данные
            double y2 = double.Parse(Console.ReadLine()); //в программу введены данные
            Console.Write("Вершины C - x3 = "); ////программа просит пользователя ввести данные
            double x3 = double.Parse(Console.ReadLine()); //в программу введены данные
            Console.Write("y3 = "); ////программа просит пользователя ввести данные
            double y3 = double.Parse(Console.ReadLine()); //в программу введены данные
            double S; //вносится переменная
            S = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)); //программа вычисляет периметр введённых данных
            Console.WriteLine("Площадь треугольника равна: " + S); //вывод данных
        }
    }
}