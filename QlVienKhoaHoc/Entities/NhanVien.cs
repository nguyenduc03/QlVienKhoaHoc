using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlVienKhoaHoc.Entities
{
    class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string BangCap { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Ho Ten : ");
            this.HoTen = Console.ReadLine();
            Console.Write("Bang Cap : ");
            this.BangCap = Console.ReadLine();
            Console.Write("Ngay Sinh : ");
            this.NgaySinh = DateTime.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten : {0}", this.HoTen);
            Console.WriteLine("Ngay Sinh : {0}", this.NgaySinh);
            Console.WriteLine("Bang Cap : {0}", this.BangCap);
        }


    }
   
}
