using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCNgay
{
    public class CNgay
    {
        // Các thuộc tính của ngày, tháng, năm
        private int Ngay;
        private int Thang;
        private int Nam;

        // Constructor mặc định lấy ngày hiện tại từ hệ thống
        public CNgay()
        {
            DateTime now = DateTime.Now;
            Ngay = now.Day;
            Thang = now.Month;
            Nam = now.Year;
        }

        // Constructor có tham số
        public CNgay(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
        }

        // Phương thức nhập ngày (nếu cần)
        public void Nhap()
        {
            Console.Write("Nhập ngày: ");
            Ngay = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            Thang = int.Parse(Console.ReadLine());

            Console.Write("Nhập năm: ");
            Nam = int.Parse(Console.ReadLine());
        }

        // Định dạng tiếng Việt
        public void Xuat()
        {
            DateTime date = new DateTime(Nam, Thang, Ngay);
            string formattedDate = date.ToString("dddd, ngày d/M/yyyy", new CultureInfo("vi-VN"));
            Console.WriteLine("Ngày: " + formattedDate);
        }

        public int getNgay()
        {
            return Ngay;
        }

        public int getThang()
        {
            return Thang;
        }

        public int getNam()
        {
            return Nam;
        }
    }
}