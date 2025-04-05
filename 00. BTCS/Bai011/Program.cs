// See https://aka.ms/new-console-template for more information

class DienTichTamGiac
{
    static void Main()
    {
        var A = NhapDiem("A");
        var B = NhapDiem("B");
        var C = NhapDiem("C");

        double S = TinhDienTichTamGiac(A, B, C);

        Console.WriteLine($"Dien tich tam giac ABC la: {S:F4}");

        return;
    }

    static Tuple<double, double> NhapDiem(string tenDiem)
    {
        Console.WriteLine($"Nhap toa do diem {tenDiem}:");

        Console.Write($"Nhap hoanh do {tenDiem}: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write($"Nhap tung do {tenDiem}: ");
        double y = double.Parse(Console.ReadLine());

        return Tuple.Create(x, y);
    }

    static double TinhDienTichTamGiac(Tuple<double, double> A, Tuple<double, double> B, Tuple<double, double> C)
    {
        double x1 = A.Item1;
        double y1 = A.Item2;

        double x2 = B.Item1;
        double y2 = B.Item2;

        double x3 = C.Item1;
        double y3 = C.Item2;

        double S = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        
        return S;
    }
}