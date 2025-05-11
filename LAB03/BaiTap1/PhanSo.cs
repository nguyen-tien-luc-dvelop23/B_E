using System;

namespace BaiTap1
{
    class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo()
        {
            TuSo = 1;
            MauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
            if (mauSo == 0)
                throw new ArgumentException("Mau so khong the bang 0.");
        }

        public void Nhap()
        {
            try
            {
                Console.Write("- Nhap tu so: ");
                TuSo = int.Parse(Console.ReadLine() ?? throw new FormatException("Du lieu nhap khong hop le."));
                Console.Write("- Nhap mau so: ");
                MauSo = int.Parse(Console.ReadLine() ?? throw new FormatException("Du lieu nhap khong hop le."));
                if (MauSo == 0)
                    throw new ArgumentException("Mau so khong the bang 0.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui long nhap so nguyen hop le.");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
                throw;
            }
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public void ToiGian()
        {
            int ucln = UCLN(TuSo, MauSo);
            if (ucln != 0)
            {
                TuSo /= ucln;
                MauSo /= ucln;
            }
        }

        public bool KiemTra()
        {
            return UCLN(TuSo, MauSo) == 1 || MauSo == 1;
        }

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tong = new PhanSo
            {
                TuSo = ps1.TuSo * ps2.MauSo + ps2.TuSo * ps1.MauSo,
                MauSo = ps1.MauSo * ps2.MauSo
            };
            if (tong.MauSo == 0)
                throw new DivideByZeroException("Mau so cua ket qua bang 0.");
            tong.ToiGian();
            return tong;
        }

        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo hieu = new PhanSo
            {
                TuSo = ps1.TuSo * ps2.MauSo - ps2.TuSo * ps1.MauSo,
                MauSo = ps1.MauSo * ps2.MauSo
            };
            if (hieu.MauSo == 0)
                throw new DivideByZeroException("Mau so cua ket qua bang 0.");
            hieu.ToiGian();
            return hieu;
        }

        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo tich = new PhanSo
            {
                TuSo = ps1.TuSo * ps2.TuSo,
                MauSo = ps1.MauSo * ps2.MauSo
            };
            if (tich.MauSo == 0)
                throw new DivideByZeroException("Mau so cua ket qua bang 0.");
            tich.ToiGian();
            return tich;
        }

        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            if (ps2.TuSo == 0)
                throw new DivideByZeroException("Chia cho phan so bang 0.");
            PhanSo thuong = new PhanSo
            {
                TuSo = ps1.TuSo * ps2.MauSo,
                MauSo = ps1.MauSo * ps2.TuSo
            };
            if (thuong.MauSo == 0)
                throw new DivideByZeroException("Mau so cua ket qua bang 0.");
            thuong.ToiGian();
            return thuong;
        }
    }
}