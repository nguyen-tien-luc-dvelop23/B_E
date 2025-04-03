using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = NhapSoNguyen("Nhập một số nguyên dương để tính giai thừa: ");
        long giaiThua = TinhGiaiThua(n);
        Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
    }
    static long TinhGiaiThua(int n)
    {
        long ketQua = 1;
        for (int i = 1; i <= n; i++)
        {
            ketQua *= i;
        }
        return ketQua;
    }
    static int NhapSoNguyen(string thongBao)
    {
        int so;
        while (true)
        {
            Console.Write(thongBao);
            if (int.TryParse(Console.ReadLine(), out so) && so >= 0)
                return so;
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}
