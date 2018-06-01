using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DanhSachGVDAL:KetNoi
    {
       
        public DataTable HienThiDS(PhanCongGiangDay x)
        {
            Open();
            string sql = "select HoTen,DiaChi,SoDienThoai from CanBoGiaoVien inner join PhanCongGiangDay on CanBoGiaoVien.MaCanBoGiaoVien=PhanCongGiangDay.MaCanBoGiaoVien where MaLop=@ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ma", x.MaLop);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public DataTable LayMaLop()
        {
            Open();
            string sql = "select MaLop,TenLop from Lop";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
    }
}
