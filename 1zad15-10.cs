using System;
 
namespace ConsoleApplication35
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("������� ����������� �����"); //��������� ������ ������������ ������ ���������� ������������� ����
            int x = int.Parse(Console.ReadLine()); //� ��������� ������� ������
            int result = (x%100)*10 + x/100; //��������� ��������� �� �������
            Console.WriteLine("���������� ����������� �����: {0}", result); //����� ������
        }
    }
}