namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите значение x="); //программа просит пользователя ввести значение переменной вещественного типа
            x = Convert.ToDouble(Console.ReadLine()); //вывод переменной
            y = Math.Tan(Math.Sqrt(Math.Log(Math.Pow(Math.E, x+1)))) - (3+Math.Sin(Math.Pow(x,2)))/(Math.Sin(Math.Pow(x,2)) - Math.Cos(Math.Pow(x,2))); // программа вычисляет введёные данные по формуле
            Console.WriteLine("Результат: {0}", y); //вывод данных
            }
    }
}
