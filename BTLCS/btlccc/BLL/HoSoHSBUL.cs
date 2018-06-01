using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class HoSoHSBUL
    {
        HoSoHSDAL cls = new HoSoHSDAL();
        public DataTable HienThiDS()
        {
            return cls.HienThiDS();
        }
        public DataTable LayMaLop()
        {
            return cls.LayMaLop();
        }
        public int Xoa(HoSoHocSinh x)
        {
            return cls.Xoa(x);
        }
        public int Them(HoSoHocSinh x)
        {
            return cls.Them(x);
        }
        public int Sua(HoSoHocSinh x)
        {
            return cls.Sua(x);
        }
        public DataTable Xem(HoSoHocSinh x)
        {
            return cls.Xem(x);
        }
        public DataTable SinhMaHS()
        {
            return cls.SinhMaHS();
        }
    }
}
