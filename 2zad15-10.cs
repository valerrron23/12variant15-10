using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("������� ��������\n������� � - x1 = "); //��������� ������ ������������ ������ ������
            double x1 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            Console.Write("y1 = "); //��������� ������ ������������ ������ ������
            double y1 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            Console.Write("������� B - x2 = "); //��������� ������ ������������ ������ ������
            double x2 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            Console.Write("y2 = "); //��������� ������ ������������ ������ ������
            double y2 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            Console.Write("������� C - x3 = "); ////��������� ������ ������������ ������ ������
            double x3 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            Console.Write("y3 = "); ////��������� ������ ������������ ������ ������
            double y3 = double.Parse(Console.ReadLine()); //� ��������� ������� ������
            double S; //�������� ����������
            S = 0.5 * Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)); //��������� ��������� �������� �������� ������
            Console.WriteLine("������� ������������ �����: " + S); //����� ������
        }
    }
}