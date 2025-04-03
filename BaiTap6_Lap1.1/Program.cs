using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        double so = NhapSoThuc("Nhập một số: ");
        if (so > 0)
            Console.WriteLine($"{so} là số dương.");
        else if (so < 0)
            Console.WriteLine($"{so} là số âm.");
        else
            Console.WriteLine($"{so} là số không.");
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
