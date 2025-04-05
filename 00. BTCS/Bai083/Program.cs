// See https://aka.ms/new-console-template for more information

using System;

class TongCacSin
{
    static void Main()
    {
        Console.WriteLine("Nhap x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap n:");
        int n = int.Parse(Console.ReadLine());

        double S = 0;
        for (int i = 1; i <= n; i++)
        {
            S += Math.Sin(Math.Pow(x, i));
        }

        Console.WriteLine("S = " + S);

        return;
    }
}