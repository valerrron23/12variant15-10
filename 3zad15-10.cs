using System;
public class Test
{
    public static int Main()
    {
        Console.Write("������� �������� ������ a = "); //��������� ������ ������������ ������ ������
        double a=Convert.ToDouble(Console.ReadLine()); //� ��������� ������� ������
        Console.Write("������� �������� ������ c = "); //��������� ������ ������������ ������ ������
        double c=Convert.ToDouble(Console.ReadLine()); //� ��������� ������� ������
        Console.Write("������� �������� ���������� b = "); //��������� ������ ������������ ������ ������
        double b=Math.Sqrt(c*c-a*a); //��������� ��������� ��������� �������� ������
        double r=(a+b-c)/2; //��������� ��������� ������ �������� ������
        Console.WriteLine("����� = "+Math.Round(b,2)); //����� ������
        Console.WriteLine("r ��������� ���. = "+Math.Round(r,2)); //����� ������
        return 0;
    }
}