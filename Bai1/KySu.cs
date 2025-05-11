using System;

namespace QLCB
{
    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public KySu() : base()
        {
            NganhDaoTao = "Unknown";
        }

        public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            NganhDaoTao = nganhDaoTao;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine() ?? "Unknown";
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }
    }
}