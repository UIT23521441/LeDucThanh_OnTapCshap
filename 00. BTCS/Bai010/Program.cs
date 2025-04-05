// See https://aka.ms/new-console-template for more information

using System;

class BieuThuc
{
    static void Main()
    {
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        double S = 0;
        for (int i = 1; i <= n; i++)
        {
            double Mu = Math.Pow(x, i);
            if ((i + 1) % 2 == 0)
                S += Mu;
            else
                S -= Mu;
        }

        Console.WriteLine($"Gia tri cua S({x}, {n}) la: {S:F4}");

        return;
    }
}
