using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = NhapSoNguyen("Nhập một số nguyên để kiểm tra có phải số nguyên tố không: ");
        if (IsPrime(n))
            Console.WriteLine($"{n} là số nguyên tố.");
        else
            Console.WriteLine($"{n} không phải là số nguyên tố.");
    }
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;  
        for (int i = 2; i <= Math.Sqrt(n); i++)  
        {
            if (n % i == 0) return false;  
        }
        return true;
    }
    static int NhapSoNguyen(string thongBao)
    {
        int so;
        while (true)
        {
            Console.Write(thongBao);
            if (int.TryParse(Console.ReadLine(), out so) && so >= 0)
                return so;
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
        }
    }
}
