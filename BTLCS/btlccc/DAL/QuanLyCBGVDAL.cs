using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class QuanLyCBGVDAL:KetNoi
    {
        public DataTable LoadData(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public DataTable HienThiDS()
        {
            string sql = "select * from CanBoGiaoVien";
            return LoadData(sql);
        }
        public int Update(string sql, string[] name, object[] value, int n)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            for (int i = 0; i < n; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        public int Them(CanBoGiaoVien x)
        {
            int n = 7;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@MaCanBo";
            name[1] = "@HoTen";
            name[2] = "@DiaChi";
            name[3] = "@SoDienThoai";
            name[4] = "@TaiKhoan";
            name[5] = "@MatKhau";
            name[6] = "@LoaiTaiKhoan";
            value[0] = x.MaCanBo;
            value[1] = x.HoTen;
            value[2] = x.DiaChi;
            value[3] = x.Sdt;
            value[4] = x.Taikhoan;
            value[5] = x.MatKHau;
            value[6] = x.LoaiTaiKhoan;
            string sql = "insert into CanBoGiaoVien values(@MaCanBo,@HoTen,@DiaChi,@SoDienThoai,@TaiKhoan,@MatKhau,@LoaiTaiKhoan)";
            return Update(sql, name, value, n);
        }
        public int Xoa(CanBoGiaoVien x)
        {
            int n = 1;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@MaCanBo";
            value[0] = x.MaCanBo;
            string sql = "delete CanBoGiaoVien where MaCanBoGiaoVien=@MaCanBo";
            return Update(sql, name, value, n);

        }
        public int Sua(CanBoGiaoVien x)
        {
            int n = 7;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@MaCanBo";
            name[1] = "@HoTen";
            name[2] = "@DiaChi";
            name[3] = "@SoDienThoai";
            name[4] = "@TaiKhoan";
            name[5] = "@MatKhau";
            name[6] = "@LoaiTaiKhoan";
            value[0] = x.MaCanBo;
            value[1] = x.HoTen;
            value[2] = x.DiaChi;
            value[3] = x.Sdt;
            value[4] = x.Taikhoan;
            value[5] = x.MatKHau;
            value[6] = x.LoaiTaiKhoan;
            string sql = "update CanBoGiaoVien set HoTen=@HoTen,DiaChi=@DiaChi,SoDienThoai=@SoDienThoai,TaiKhoan=@TaiKhoan,MatKhau=@MatKhau,LoaiTaiKhoan=@LoaiTaiKhoan where MaCanBoGiaoVien=@MaCanBo";
            return Update(sql, name, value, n);
        }
        public DataTable Xem(CanBoGiaoVien x)
        {
            Open();
            string sql = "select * from CanBoGiaoVien where MaCanBoGiaoVien=@MaCanBo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("MaCanBo", x.MaCanBo);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public DataTable SinhMaCBGV()
        {
            return LoadData("SELECT TOP(1) CAST(RIGHT(MaCanBoGiaoVien, 4) + 1 AS integer) AS SV FROM CanBoGiaoVien ORDER BY MaCanBoGiaoVien DESC");
        }
    }
}
