using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double doC = NhapSoThuc("Nhập nhiệt độ (°C): ");
        double doF = (doC * 9 / 5) + 32;

        // Hiển thị kết quả
        Console.WriteLine($"{doC}°C tương đương {doF}°F");
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
