using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlVienKhoaHoc.Entities
{
    class NhaQuanLy : NhanVien
    {
        public float BacLuong { get; set; }
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Bac Luong : ");
            this.BacLuong = float.Parse(Console.ReadLine());

            Console.Write("ChucVu : ");
            this.ChucVu = Console.ReadLine();

            Console.Write("So Ngay Cong : ");
            this.SoNgayCong = int.Parse(Console.ReadLine());

        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Bac Luong : {0}", this.BacLuong);
            Console.WriteLine("Chuc Vu : {0}", this.ChucVu);

            Console.WriteLine("So Ngay Cong : {0}", this.SoNgayCong);
        }

    }
}
