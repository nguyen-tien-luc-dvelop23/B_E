using System;

namespace QLCB
{
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo()
        {
            HoTen = "Unknown";
            NamSinh = 1990;
            GioiTinh = "Nam";
            DiaChi = "Unknown";
        }

        public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "Unknown";
            Console.Write("Nhap nam sinh: ");
            if (!int.TryParse(Console.ReadLine(), out int namSinh))
            {
                Console.WriteLine("Nam sinh khong hop le, mac dinh la 1990.");
                NamSinh = 1990;
            }
            else
            {
                NamSinh = namSinh;
            }
            Console.Write("Nhap gioi tinh (Nam/Nu): ");
            GioiTinh = Console.ReadLine() ?? "Nam";
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine() ?? "Unknown";
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
        }
    }
}