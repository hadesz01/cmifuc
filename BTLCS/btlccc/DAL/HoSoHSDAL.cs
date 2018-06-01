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
    public class HoSoHSDAL:QuanLyCBGVDAL
    {
        QuanLyCBGVDAL cls = new QuanLyCBGVDAL();
        public DataTable HienThiDS()
        {
            return cls.LoadData("select * from HoSoHocSinh");
        }
        public DataTable LayMaLop()
        {
            return cls.LoadData("select MaLop,TenLop from Lop");
        }
        public int Xoa(HoSoHocSinh x)
        {
            int n = 1;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@MaHocSinh";
            value[0] = x.MaHocSinh;
            string sql = "delete HoSoHocSinh where MaHocSinh=@MaHocSinh";
            return cls.Update(sql, name, value, n);
        }
        public int Them(HoSoHocSinh x)
        {
            int n = 9;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@ma";
            name[1] = "@hoten";
            name[2] = "@ngaysinh";
            name[3] = "@gioitinh";
            name[4] = "@diachi";
            name[5] = "@diem";
            name[6] = "@hotenbo";
            name[7] = "@sdt";
            name[8] = "@malop";
            value[0]=x.MaHocSinh;
            value[1]=x.HoTen;
            value[2]=x.NgaySinh;
            value[3]=x.GioiTinh;
            value[4]=x.DiaChi;
            value[5]=x.DiemVAotruong;
            value[6]=x.HoTenBoMe;
            value[7]=x.sdt;
            value[8]=x.MaLop;
            string sql = "insert into HoSoHocSinh values(@ma,@hoten,@ngaysinh,@gioitinh,@diachi,@diem,@hotenbo,@sdt,@malop)";
            return cls.Update(sql, name, value, n);
        }
        public int Sua(HoSoHocSinh x)
        {
            int n = 9;
            string[] name = new string[n];
            object[] value = new object[n];
            name[0] = "@ma";
            name[1] = "@hoten";
            name[2] = "@ngaysinh";
            name[3] = "@gioitinh";
            name[4] = "@diachi";
            name[5] = "@diem";
            name[6] = "@hotenbo";
            name[7] = "@sdt";
            name[8] = "@malop";
            value[0] = x.MaHocSinh;
            value[1] = x.HoTen;
            value[2] = x.NgaySinh;
            value[3] = x.GioiTinh;
            value[4] = x.DiaChi;
            value[5] = x.DiemVAotruong;
            value[6] = x.HoTenBoMe;
            value[7] = x.sdt;
            value[8] = x.MaLop;
            string sql = "update HoSoHocSinh set Hoten=@hoten,NgaySinh=@ngaysinh,GioiTinh=@gioitinh,DiaChi=@diachi,DiemVaoTruong=@diem,HoTenBoMe=@hotenbo,SoDienThoai=@sdt,MaLop=@malop where MaHocSinh=@ma";
            return cls.Update(sql, name, value, n);
        }
        public DataTable Xem(HoSoHocSinh x)
        {
            Open();
            string sql = "select * from HoSoHocSinh where MaHocSinh=@ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ma", x.MaHocSinh);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public DataTable SinhMaHS()
        {
            return cls.LoadData("SELECT TOP(1) CAST(RIGHT(MaHocSinh, 4) + 1 AS integer) AS SV FROM HoSoHocSinh ORDER BY MaHocSinh DESC");
        }
    }
}
