// See https://aka.ms/new-console-template for more information
using System;

class TinhSoHangThuNcuaDay
{
    static void Main()
    {
        Console.WriteLine("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        double att = -2;
        double at = 0;

        for (int i = 2; i <= n; i++)
        {
            at = 5 * att + 2 * Math.Pow(3, i) - 6 * Math.Pow(7, i) + 12;
            att = at;
        }

        Console.WriteLine("So hang thu " + n + " cua day la: " + at);
        return;
    }
}