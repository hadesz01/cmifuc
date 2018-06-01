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
    public class QuanLyCBGVBUL
    {
        QuanLyCBGVDAL cls = new QuanLyCBGVDAL();
        public DataTable HienThiDS()
        {
            return cls.HienThiDS();
        }
        public DataTable Xem(CanBoGiaoVien x)
        {
            return cls.Xem(x);
        }
        public int Them(CanBoGiaoVien x)
        {
            return cls.Them(x);
        }
        public int Sua(CanBoGiaoVien x)
        {
            return cls.Sua(x);
        }
        public int Xoa(CanBoGiaoVien x)
        {
            return cls.Xoa(x);
        }
        public DataTable SinhMaCBGV()
        {
            return cls.SinhMaCBGV();
        }
    }
}
