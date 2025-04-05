// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Globalization;
using XayDungCNgay;
using XayDungCThoiGian;

class Program
{
    static void Main()
    {
        while (true)
        {
            CNgay ngayHienTai = new CNgay();

            CThoiGian thoiGianHienTai = new CThoiGian();

            DateTime date = new DateTime(ngayHienTai.getNam(), ngayHienTai.getThang(), ngayHienTai.getNgay());
            string formattedDate = date.ToString("dddd, ngày d/M/yyyy", new CultureInfo("vi-VN"));

            string formattedTime = $"{thoiGianHienTai.getGio():D2}:{thoiGianHienTai.getPhut():D2}:{thoiGianHienTai.getGiay():D2}";

            Console.WriteLine($"Thời gian hiện tại: {formattedDate}, thời gian: {formattedTime}");

            Thread.Sleep(1000);
        }
    }
}

