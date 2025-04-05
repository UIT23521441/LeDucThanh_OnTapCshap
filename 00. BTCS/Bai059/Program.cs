// See https://aka.ms/new-console-template for more information

using System;

class DemSoLuongChuSo
{
    static void Main()
    {
        Console.WriteLine("Nhap so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        int Dem = 0;
        while(n > 0)
        {
            n /= 10;
            Dem++;
        }

        Console.WriteLine("So luong chu so cua n: " + Dem);

        return;
    }
}