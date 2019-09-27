using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM
{
    public class Diem
    {
        public double HoanhDo { get; set; }
        public double TungDo { get; set; }
        public Diem(double x,double y)
        {
            this.HoanhDo = x;
            this.TungDo = y;
        }
        public double TinhKhoanCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(this.HoanhDo - d.HoanhDo, 2 )) + (Math.Pow(this.TungDo - d.TungDo, 2)); 
        }
    }
    public class HinhChuNhat
    {
        public Diem TrenTrai { get; set; }
        public Diem DuoiPhai { get; set; }
        public HinhChuNhat(Diem trenTrai,Diem duoiPhai)
        {
            if (trenTrai.HoanhDo > duoiPhai.HoanhDo || trenTrai.TungDo < duoiPhai.TungDo)
                throw new ArgumentException("Input invalid");
            this.TrenTrai = trenTrai;
            this.DuoiPhai = duoiPhai;
        }
        public double TinhDienTich()
        {
            double width = this.DuoiPhai.HoanhDo - this.TrenTrai.HoanhDo;
            double height = this.TrenTrai.TungDo - this.DuoiPhai.TungDo;

            return 0;
        }
    }
}
