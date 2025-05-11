using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double chieuDai = NhapSoThuc("Nhập chiều dài: ");
        double chieuRong = NhapSoThuc("Nhập chiều rộng: ");
        double dienTich = chieuDai * chieuRong;
        Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
    }
    static double NhapSoThuc(string thongBao)
    {
        double so;
        while (true)
        {
            Console.Write(thongBao);
            if (double.TryParse(Console.ReadLine(), out so) && so > 0)
                return so;
            Console.WriteLine("Vui lòng nhập một số thực dương hợp lệ!");
        }
    }
}
