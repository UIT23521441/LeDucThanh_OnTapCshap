using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCPhanSo
{
    public class CPhanSo
    {
        private int Tu;
        private int Mau;

        public CPhanSo()
        {
            Tu = 0;
            Mau = 1;  
        }

        public CPhanSo(int TuTu, int MauMau)
        {
            Tu = TuTu;
            Mau = MauMau;
        }

        public CPhanSo(CPhanSo x)
        {
            Tu = x.Tu;
            Mau = x.Mau;
        }

        ~CPhanSo()
        {
            // Code để giải phóng tài nguyên (nếu cần thiết)
            Console.WriteLine($"Phân số {Tu}/{Mau} đã được hủy.");
            return;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            Tu = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.Write("Nhập mẫu số (khác 0): ");
            //    Mau = int.Parse(Console.ReadLine());
            //    if (Mau == 0)
            //    {
            //        Console.WriteLine("Mẫu số không thể là 0. Vui lòng nhập lại.");
            //    }
            //} while (Mau == 0);
            Console.Write("Nhập mẫu số: ");
            Mau = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{Tu}/{Mau}");
        }

        public int getTu()
        {
            return Tu;
        }

        public int getMau()
        {
            return Mau;
        }

        public void RutGon()
        {
            int ucln = UCLN();
            Tu /= ucln;
            Mau /= ucln;
        }

        private int UCLN()
        {
            int a = Math.Abs(Tu);
            int b = Math.Abs(Mau);
            while (a * b != 0)
            {
                if(a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            return a + b;
        }

        public static int SoSanh(CPhanSo ps1, CPhanSo ps2)
        {
            double a = (double)ps1.Tu / ps1.Mau;
            double b = (double)ps2.Tu / ps2.Mau;
            if (a > b) 
                return 1;

            if (a < b) 
                return -1;
            return 0;
        }

        public static CPhanSo Tong(CPhanSo ps1, CPhanSo ps2)
        {
            int TuTu = ps1.Tu * ps2.Mau + ps2.Tu * ps1.Mau;
            int MauMau = ps1.Mau * ps2.Mau;
            CPhanSo ketqua = new CPhanSo(TuTu, MauMau);
            ketqua.RutGon();
            return ketqua;
        }

        public static CPhanSo Hieu(CPhanSo ps1, CPhanSo ps2)
        {
            int TuTu = ps1.Tu * ps2.Mau - ps2.Tu * ps1.Mau;
            int MauMau = ps1.Mau * ps2.Mau;
            CPhanSo ketqua = new CPhanSo(TuTu, MauMau);
            ketqua.RutGon();
            return ketqua;
        }

        public static CPhanSo Tich(CPhanSo ps1, CPhanSo ps2)
        {
            int TuTu = ps1.Tu * ps2.Tu;
            int MauMau = ps1.Mau * ps2.Mau;
            CPhanSo ketqua = new CPhanSo(TuTu, MauMau);
            ketqua.RutGon();
            return ketqua;
        }

        public static CPhanSo Thuong(CPhanSo ps1, CPhanSo ps2)
        {
            int TuTu = ps1.Tu * ps2.Mau;
            int MauMau = ps1.Mau * ps2.Tu;
            CPhanSo ketqua = new CPhanSo(TuTu, MauMau);
            ketqua.RutGon();
            return ketqua;
        }

        public static void SapXepTangDan(CPhanSo[] ps)
        {
            Array.Sort(ps, (x, y) => SoSanh(x, y));
        }

        public static void SapXepGiamDan(CPhanSo[] ps)
        {
            Array.Sort(ps, (x, y) => SoSanh(y, x));
        }
    }
}
