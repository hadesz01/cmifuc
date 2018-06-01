using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace WindowsFormsApp15
{
    public partial class frmQLDMGiaoVien : Form
    {
        public frmQLDMGiaoVien()
        {
            InitializeComponent();
        }
        
        private void frmQLDMGiaoVien_Load(object sender, EventArgs e)
        {
            QuanLyCBGVBUL cls = new QuanLyCBGVBUL();
            dgvCBGV.DataSource = cls.HienThiDS();
            DataTable dta = new DataTable();
            dta.Columns.Add("loai", typeof(string));
            dta.Columns.Add("ten", typeof(string));

            dta.Rows.Add("admin", "admin");
            dta.Rows.Add("gv", "Giáo Viên");

            cboLoaiTK.DataSource = dta;

            cboLoaiTK.DisplayMember = "ten";
            cboLoaiTK.ValueMember = "loai";
            dgvCBGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyCBGVBUL cls = new QuanLyCBGVBUL();
            CanBoGiaoVien x = new CanBoGiaoVien();
            x.MaCanBo = txtMaCBGV.Text;
            x.HoTen = txtHoTen.Text;
            x.DiaChi = txtDiaChi.Text;
            x.Sdt = txtSDT.Text;
            x.Taikhoan = txtTaiKhoan.Text;
            x.MatKHau = txtMatKhau.Text;
            x.LoaiTaiKhoan = cboLoaiTK.SelectedValue.ToString();
            cls.Them(x);
            frmQLDMGiaoVien_Load(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            QuanLyCBGVBUL cls = new QuanLyCBGVBUL();
            CanBoGiaoVien x = new CanBoGiaoVien();
            x.MaCanBo = txtMaCBGV.Text;
            dgvCBGV.DataSource = cls.Xem(x);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyCBGVBUL cls = new QuanLyCBGVBUL();
            CanBoGiaoVien x = new CanBoGiaoVien();
            x.MaCanBo = txtMaCBGV.Text;
            x.HoTen = txtHoTen.Text;
            x.DiaChi = txtDiaChi.Text;
            x.Sdt = txtSDT.Text;
            x.Taikhoan = txtTaiKhoan.Text;
            x.MatKHau = txtMatKhau.Text;
            x.LoaiTaiKhoan = cboLoaiTK.SelectedValue.ToString();
            cls.Sua(x);
            frmQLDMGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyCBGVBUL cls = new QuanLyCBGVBUL();
            CanBoGiaoVien x = new CanBoGiaoVien();
            x.MaCanBo = txtMaCBGV.Text;
            cls.Xoa(x);
            frmQLDMGiaoVien_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmQLDMGiaoVien_Load(sender, e);
        }


    }
}
