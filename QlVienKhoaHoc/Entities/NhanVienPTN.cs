using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlVienKhoaHoc.Entities
{
    class NhanVienPTN : NhanVien
    {
        public double LuongTrongThang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Luong Trong Thang : ");
            this.LuongTrongThang = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Luong Trong Thang : {0}", this.LuongTrongThang);
        }
    }
}
