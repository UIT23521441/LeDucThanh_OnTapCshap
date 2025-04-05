using System;
using XayDungCPhanSo;

class Bai01
{
    static void Main()
    {
        Console.WriteLine("Nhap so luong phan so: ");
        int n = int.Parse(Console.ReadLine());

        CPhanSo[] ps = new CPhanSo[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan so thu {i + 1}:");
            ps[i] = new CPhanSo();
            ps[i].Nhap();
        }

        Console.WriteLine("Cac phan so da nhap la: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan so thu {i + 1}: ");
            ps[i].Xuat();
        }

        Console.WriteLine("Tong cac phan so la: ");
        CPhanSo tong = ps[0];
        for (int i = 1; i < n; i++)
        {
            tong = CPhanSo.Tong(tong, ps[i]);
        }
        tong.Xuat(); // In kết quả tổng

        Console.Write("Hieu cac phan so la: ");
        CPhanSo hieu = ps[0];
        for (int i = 1; i < n; i++)
        {
            hieu = CPhanSo.Hieu(hieu, ps[i]);
        }
        hieu.Xuat(); // In kết quả hiệu

        Console.Write("Tich cac phan so la: ");
        CPhanSo tich = ps[0];
        for (int i = 1; i < n; i++)
        {
            tich = CPhanSo.Tich(tich, ps[i]);
        }
        tich.Xuat(); // In kết quả tích

        if (n >= 2)
        {
            Console.Write("Thuong cua hai phan so bat ky la: ");
            CPhanSo thuong = CPhanSo.Thuong(ps[0], ps[1]);
            thuong.Xuat(); // In kết quả thương
        }

        Console.WriteLine("Mang phan so tang dan: ");
        CPhanSo.SapXepTangDan(ps);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan so thu {i + 1}: ");
            ps[i].Xuat();
        }

        Console.WriteLine("Mang phan so giam dan: ");
        CPhanSo.SapXepGiamDan(ps);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan so thu {i + 1}: ");
            ps[i].Xuat();
        }
    }
}
