using System;
using System.Collections.Generic;

namespace QLCB
{
    class QLCB
    {
        private List<CanBo> danhSachCanBo;

        public QLCB()
        {
            danhSachCanBo = new List<CanBo>();
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Ban muon nhap thong tin cho loai can bo nao?");
            Console.WriteLine("1. Cong nhan");
            Console.WriteLine("2. Ky su");
            Console.WriteLine("3. Nhan vien");
            Console.Write("Nhap lua chon (1-3): ");

            if (!int.TryParse(Console.ReadLine(), out int luaChon) || luaChon < 1 || luaChon > 3)
            {
                Console.WriteLine("Lua chon khong hop le!");
                return;
            }

            CanBo canBo = luaChon switch
            {
                1 => new CongNhan(),
                2 => new KySu(),
                3 => new NhanVien(),
                _ => null
            };

            if (canBo != null)
            {
                canBo.Nhap();
                danhSachCanBo.Add(canBo);
                Console.WriteLine("Da them can bo thanh cong!");
            }
        }

        public void TimKiemTheoHoTen()
        {
            Console.Write("Nhap ho ten can tim: ");
            string hoTen = Console.ReadLine() ?? "";
            bool found = false;

            foreach (var canBo in danhSachCanBo)
            {
                if (canBo.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    canBo.HienThi();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Khong tim thay can bo voi ho ten nay!");
            }
        }

        public void HienThiDanhSach()
        {
            if (danhSachCanBo.Count == 0)
            {
                Console.WriteLine("Danh sach can bo trong!");
                return;
            }

            Console.WriteLine("Danh sach can bo:");
            foreach (var canBo in danhSachCanBo)
            {
                canBo.HienThi();
                Console.WriteLine("---------");
            }
        }

        static void Main(string[] args)
        {
            QLCB quanLy = new QLCB();
            while (true)
            {
                Console.WriteLine("\nChuong trinh quan ly can bo");
                Console.WriteLine("1. Nhap thong tin can bo");
                Console.WriteLine("2. Tim kiem theo ho ten");
                Console.WriteLine("3. Hien thi danh sach can bo");
                Console.WriteLine("4. Thoat chuong trinh");
                Console.Write("Nhap lua chon (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out int luaChon))
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        quanLy.NhapThongTin();
                        break;
                    case 2:
                        quanLy.TimKiemTheoHoTen();
                        break;
                    case 3:
                        quanLy.HienThiDanhSach();
                        break;
                    case 4:
                        Console.WriteLine("Tam biet!");
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}