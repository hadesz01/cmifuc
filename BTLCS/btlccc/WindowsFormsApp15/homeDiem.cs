using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace WindowsFormsApp15
{
    public partial class homeDiem : Form
    {
        public homeDiem()
        {
            InitializeComponent();
        }
        public string magv;
        public string tengv;
        QuanLyDiemBLL ql = new QuanLyDiemBLL();
        CanBoGiaoVienBLL cc = new CanBoGiaoVienBLL();
        //lay thong tin giao vien
        private void Lay()
        {
            foreach (var item in cc.dscb())
            {
                if (magv == item.MaCanBo)
                {
                    ten.Text = item.HoTen;
                    ma.Text = item.MaCanBo;
                    lbht.Text = item.HoTen;
                    lbdiachi.Text = item.DiaChi;
                    lbloaitk.Text = item.LoaiTaiKhoan;
                    lbmatkhau.Text = item.MatKHau;
                    lbma.Text = item.MaCanBo;
                    lbsdt.Text = item.Sdt;
                    lbloaitk.Text = item.LoaiTaiKhoan;
                    lbtaikhoan.Text = item.Taikhoan;
                }
            }
        }
        private void homeDiem_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Lay();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss  dd-MM-yyyy");
        }
    }
}
