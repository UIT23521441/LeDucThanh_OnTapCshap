// See https://aka.ms/new-console-template for more information
using System;

class DienTichDaGiacDeu
{
    static void Main()
    {
        Console.Write("Nhap so canh: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap ban kinh: ");
        double r = double.Parse(Console.ReadLine());

        double S = 0.5 * n * r * r * Math.Sin((2 * Math.PI) / n);

        Console.WriteLine($"Dien tich da giac deu la: {S:F4}");

        return;
    }
}
