using System;

namespace QLCB
{
    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien() : base()
        {
            CongViec = "Unknown";
        }

        public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            CongViec = congViec;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine() ?? "Unknown";
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }
}