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
    public partial class DanhSachGiaoVien : Form
    {
        public DanhSachGiaoVien()
        {
            InitializeComponent();
        }

        private void DanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            DanhSachGVBUL cls = new DanhSachGVBUL();
            cboTenLop.DataSource = cls.LayMaLop();
            cboTenLop.DisplayMember = "TenLop";
            cboTenLop.ValueMember = "MaLop";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DanhSachGVBUL cls = new DanhSachGVBUL();
            PhanCongGiangDay x = new PhanCongGiangDay();
            x.MaLop = cboTenLop.SelectedValue.ToString();
            dgvDSGV.DataSource = cls.HienThiDS(x);
            dgvDSGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
