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
    public partial class frmHoSoHocSinh : Form
    {
        public frmHoSoHocSinh()
        {
            InitializeComponent();
        }

        private void txtMaCBGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýHồSơHSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmHoSoHocSinh_Load(object sender, EventArgs e)
        {
            HoSoHSBUL cls = new HoSoHSBUL();
            dgvHocSinh.DataSource = cls.HienThiDS();
            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboMaLop.DataSource = cls.LayMaLop();
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
            DataTable dta = new DataTable();
            dta.Columns.Add("gioitinh", typeof(string));
            dta.Columns.Add("ten", typeof(string));

            dta.Rows.Add("Nam", "Nam");
            dta.Rows.Add("Nu", "Nữ");
            cboGioiTinh.DataSource = dta;
            cboGioiTinh.DisplayMember = "ten";
            cboGioiTinh.ValueMember = "gioitinh";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoSoHSBUL cls = new HoSoHSBUL();
            HoSoHocSinh x = new HoSoHocSinh();
            x.MaHocSinh = txtMaHS.Text;
            cls.Xoa(x);
            frmHoSoHocSinh_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoSoHSBUL cls = new HoSoHSBUL();
            HoSoHocSinh x = new HoSoHocSinh();
            x.MaHocSinh = txtMaHS.Text;
            x.HoTen = txtHoTen.Text;
            x.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            x.GioiTinh = cboGioiTinh.SelectedValue.ToString();
            x.DiaChi = txtDiaChi.Text;
            x.DiemVAotruong = double.Parse(txtDiemVaoTruong.Text);
            x.HoTenBoMe = txtHoTenBoMe.Text;
            x.sdt = txtSDT.Text;
            x.MaLop = cboMaLop.SelectedValue.ToString();
            cls.Them(x);
            frmHoSoHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoSoHSBUL cls = new HoSoHSBUL();
            HoSoHocSinh x = new HoSoHocSinh();
            x.MaHocSinh = txtMaHS.Text;
            x.HoTen = txtHoTen.Text;
            x.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
            x.GioiTinh = cboGioiTinh.SelectedValue.ToString();
            x.DiaChi = txtDiaChi.Text;
            x.DiemVAotruong = double.Parse(txtDiemVaoTruong.Text);
            x.HoTenBoMe = txtHoTenBoMe.Text;
            x.sdt = txtSDT.Text;
            x.MaLop = cboMaLop.SelectedValue.ToString();
            cls.Sua(x);
            frmHoSoHocSinh_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmHoSoHocSinh_Load(sender, e);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HoSoHSBUL cls = new HoSoHSBUL();
            HoSoHocSinh x = new HoSoHocSinh();
            x.MaHocSinh = txtMaHS.Text;
            dgvHocSinh.DataSource = cls.Xem(x);
        }

    }
}
