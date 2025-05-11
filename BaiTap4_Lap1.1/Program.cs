using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int so = NhapSoNguyen("Nhập một số nguyên: ");
        if (so % 2 == 0)
            Console.WriteLine($"{so} là số chẵn.");
        else
            Console.WriteLine($"{so} là số lẻ.");
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
