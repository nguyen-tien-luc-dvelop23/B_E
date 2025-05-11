using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Nhập năm từ bàn phím
        int nam = NhapSoNguyen("Nhập năm cần kiểm tra: ");

        // Kiểm tra năm nhuận
        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            Console.WriteLine($"{nam} là năm nhuận.");
        else
            Console.WriteLine($"{nam} không phải là năm nhuận.");
    }
    static int NhapSoNguyen(string thongBao)
    {
        int so;
        while (true)
        {
            Console.Write(thongBao);
            if (int.TryParse(Console.ReadLine(), out so) && so > 0)
                return so;
            Console.WriteLine("Vui lòng nhập một năm hợp lệ (số nguyên dương)!");
        }
    }
}
