using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlVienKhoaHoc.Entities
{
    class NhaKhoaHoc : NhaQuanLy
    {
        
        public int SoBaiBao { get; set; }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("So Bai Bao : ");
            this.SoBaiBao = int.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("So Bai Bao : {0}", this.SoBaiBao);
        }
    }
}
