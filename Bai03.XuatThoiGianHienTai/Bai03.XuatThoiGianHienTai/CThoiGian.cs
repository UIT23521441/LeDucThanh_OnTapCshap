using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungCThoiGian
{
    public class CThoiGian
    {
        // Các thuộc tính giờ, phút, giây
        private int Gio;
        private int Phut;
        private int Giay;

        // Phương thức thiết lập mặc định (không tham số) lấy thời gian hiện tại
        public CThoiGian()
        {
            DateTime now = DateTime.Now;
            Gio = now.Hour;
            Phut = now.Minute;
            Giay = now.Second;
        }

        ~CThoiGian()
        {
            return;
        }

        // Phương thức xuất thời gian hiện tại
        public void Xuat()
        {
            string formattedTime = $"{Gio:D2}:{Phut:D2}:{Giay:D2}";  // Định dạng giờ:phút:giây
            Console.WriteLine("Thời gian hiện tại: " + formattedTime);
        }

        public int getGio()
        {
            return Gio;
        }

        public int getPhut()
        {
            return Phut;
        }

        public int getGiay()
        {
            return Giay;
        }

        // Phương thức cập nhật thời gian hiện tại
        public void CapNhatThoiGian()
        {
            DateTime now = DateTime.Now;
            Gio = now.Hour;
            Phut = now.Minute;
            Giay = now.Second;
        }
    }
}
