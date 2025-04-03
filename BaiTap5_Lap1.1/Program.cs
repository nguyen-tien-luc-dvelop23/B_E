using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double so1 = NhapSoThuc("Nhập số thứ nhất: ");
        double so2 = NhapSoThuc("Nhập số thứ hai: ");
        double tong = so1 + so2;
        double tich = so1 * so2;
        Console.WriteLine($"Tổng của {so1} và {so2} là: {tong}");
        Console.WriteLine($"Tích của {so1} và {so2} là: {tich}");
    }
    static double NhapSoThuc(string thongBao)
    {
        double so;
        while (true)
        {
            Console.Write(thongBao);
            if (double.TryParse(Console.ReadLine(), out so))
                return so;
            Console.WriteLine("Vui lòng nhập một số thực hợp lệ!");
        }
    }
}
