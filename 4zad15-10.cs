namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("������� �������� x="); //��������� ������ ������������ ������ �������� ���������� ������������� ����
            x = Convert.ToDouble(Console.ReadLine()); //����� ����������
            y = Math.Tan(Math.Sqrt(Math.Log(Math.Pow(Math.E, x+1)))) - (3+Math.Sin(Math.Pow(x,2)))/(Math.Sin(Math.Pow(x,2)) - Math.Cos(Math.Pow(x,2))); // ��������� ��������� ������� ������ �� �������
            Console.WriteLine("���������: {0}", y); //����� ������
            }
    }
}