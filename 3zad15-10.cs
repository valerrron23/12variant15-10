using System;
public class Test
{
    public static int Main()
    {
        Console.Write("Введите значения катета a = "); //программа просит пользователя ввести данные
        double a=Convert.ToDouble(Console.ReadLine()); //в программу введены данные
        Console.Write("Введите значения катета c = "); //программа просит пользователя ввести данные
        double c=Convert.ToDouble(Console.ReadLine()); //в программу введены данные
        Console.Write("Введите значения гипотенузы b = "); //программа просит пользователя ввести данные
        double b=Math.Sqrt(c*c-a*a); //программа вычисляет гиперболу введённых данных
        double r=(a+b-c)/2; //программа вычисляет радиус введённых данных
        Console.WriteLine("Катет = "+Math.Round(b,2)); //вывод данных
        Console.WriteLine("r вписанной окр. = "+Math.Round(r,2)); //вывод данных
        return 0;
    }
}