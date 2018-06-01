using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class DanhSachGVBUL
    {
        DanhSachGVDAL cls = new DanhSachGVDAL();
        public DataTable HienThiDS(PhanCongGiangDay x)
        {
            return cls.HienThiDS(x);
        }
        public DataTable LayMaLop()
        {
            return cls.LayMaLop();
        }
    }
}
