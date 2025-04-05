// See https://aka.ms/new-console-template for more information

using System;

class TinhBieuThuc
{
    static void Main()
    {
        Console.WriteLine("Nhap x:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap n:");
        int n = int.Parse(Console.ReadLine());

        double S = 0;
        int m = 0;
        int Dau = -1;
        for (int i = 1; i <= n; i++)
        {
            m += i;
            S += Dau * Math.Pow(x, i) / m;
            Dau = -Dau;
        }

        Console.WriteLine("S = " + S);

        return;
    }
}