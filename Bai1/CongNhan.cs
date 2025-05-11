using System;

namespace QLCB
{
    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public CongNhan() : base()
        {
            Bac = "3/7";
        }

        public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            Bac = bac;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap bac (vi du: 3/7): ");
            Bac = Console.ReadLine() ?? "3/7";
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bac: {Bac}");
        }
    }
}