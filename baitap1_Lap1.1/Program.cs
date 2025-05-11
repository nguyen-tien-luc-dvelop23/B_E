using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();
        int tuoi = NhapSoNguyen("Nhập tuổi của bạn: ");

        // Hiển thị kết quả
        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }
    static int NhapSoNguyen(string thongBao)
    {
        int so;
        while (true)
        {
            Console.Write(thongBao);
            if (int.TryParse(Console.ReadLine(), out so))
                return so;
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
        }
    }
}
