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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        //btn
        public bool gv = false;
        public bool ad = false;
        public string TenUsers { get; set; }
        public string MaGV { get; set; }

        frmHoSoHocSinh qlHocSinh = new frmHoSoHocSinh();
        frmQLDMGiaoVien qlGV = new frmQLDMGiaoVien();
        QuanLyDiem qlDiem = new QuanLyDiem();
        home hm = new home();
        //QuanLyGiaovien qlGiaoVien = new QuanLyGiaovien();
        //QuanLyHocSinh qlHocSinh = new QuanLyHocSinh();
        PhanCongGD qlgd = new PhanCongGD();
        QuanLyLop qlLOp = new QuanLyLop();

        DanhSachGiaoVien tkGV = new DanhSachGiaoVien();
        //ThongKeGV tkGV = new ThongKeGV();
        ThongKeHS tkHS = new ThongKeHS();
        QuanLyMonHoc qlMOnHoc = new QuanLyMonHoc();
        PhanCongGiangDay Phan = new PhanCongGiangDay();
        private bool chkqlDiem = false;
        private Button disQuanLyDiem = null, clsQuanLyDiem = null,
                                disPhanCong = null, clsPhanCong = null,
                                 disLopHoc = null, clsLopHoc = null,
                                     disGiaoVien = null, clsGiaovien = null,
             disMonHoc = null, clsMonHoc = null,
             disTkgiaovien = null, clsTkgiaovien = null,
             disTkHocSinh = null, clsTkHocSinh = null,
             disHocsinh = null, clsHocSinh = null;

        private void btnThongKeHs_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
            Them(tkHS);
            if (Application.OpenForms["ThongKeHS"] as ThongKeHS == null)
            {
                tkHS.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            Them(qlGV);
            if (Application.OpenForms["frmQLDMGiaoVien"] as frmQLDMGiaoVien == null)
            {
                qlGV.Show();
            }
        }

        //panel
        private Panel pnDiem = null, pnLop = null, pnHOCsinh = null, pnTKHocsinh = null, pnTKGIaovien = null,
            pnPhancong = null,
        pnMonHoc = null, pnGiaoVien = null;

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            max.Visible = false;
            moo.Visible = true;
            
        }

        private void moo_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            max.Visible = true;
            moo.Visible = false;
        }

        private void BaoForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                //if (Application.OpenForms[i].Name != "Menu")
                Application.OpenForms[i].Close();
            }
        }

        private void doDucVinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
          

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "login")
                Application.OpenForms[i].Close();
            }
            login a = new login();
            a.Show();
          
        }

        private void phancong_Click(object sender, EventArgs e)
        {
          
        }

        private void giaovien_Click(object sender, EventArgs e)
        {
            
        }

        private void monhoc_Click(object sender, EventArgs e)
        {
          
        }

        private void lophoc_Click(object sender, EventArgs e)
        {
           
        }

        private void hocsinh_Click(object sender, EventArgs e)
        {
          
           
        }

        private void tkhss_Click(object sender, EventArgs e)
        {
            btnThongKeHs_Click(null, null);
        }

        private void tkgvv_Click(object sender, EventArgs e)
        {
            btnThongKEGiaoVien_Click(null, null);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
                btnQuanLyLopHoc_Click(null,null);
            if (tabControl1.SelectedIndex == 1)
                btnQuanLyHocSinh_Click(null, null);
            if (tabControl1.SelectedIndex == 2)
                btnQuanLyMonHoc_Click(null, null);
            if (tabControl1.SelectedIndex == 4)
                btnQuanLyGiaoVien_Click(null, null);
            if (tabControl1.SelectedIndex == 5)
                btnPhanCongGiangDay_Click(null, null);
            if (tabControl1.SelectedIndex == 6)
                btnThongKEGiaoVien_Click(null, null);
            if (tabControl1.SelectedIndex == 7)
                btnThongKeHs_Click(null, null);
            if (tabControl1.SelectedIndex == 0)
            {

                Them(hm);
                if (Application.OpenForms["home"] as home == null)
                {
                    hm.Show();
                }
            }
                
        }

        private void home_Click(object sender, EventArgs e)
        {
            
            Them(hm);
            if (Application.OpenForms["home"] as home == null)
            {
                hm.Show();
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (gv)
            {
                Them(hm);
                if (Application.OpenForms["home"] as home == null)
                {
                    hm.Show();
                }
            }
            else
            {
                tabControl1_SelectedIndexChanged(null, null);
            }
        }

        private void hocsinh_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BaoForm_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnThongKEGiaoVien_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=6;
            Them(tkGV);
            if (Application.OpenForms["DanhSachGiaoVien"] as DanhSachGiaoVien == null)
            {
                tkGV.Show();
            }
        }
        

        // disQuanLyDiem = null, clsQuanLyDiem = null,;
        //btnLen
        private void button6_Click(object sender, EventArgs e)
        {
            btnLen.Visible = false;
            btnXuong.Visible = true;
            pnDanhMuc.Visible = true;
            if (pnThongKe.Visible == false)
            {
                pnXuong.Location = new System.Drawing.Point(3, 240);
                pictureBox1.Location = new System.Drawing.Point(3, 381);
                // pnDanhMuc.Location = new System.Drawing.Point(3,66);
            }
            else {
                pnXuong.Location = new System.Drawing.Point(3, 240);
                pictureBox1.Location = new System.Drawing.Point(3, 471);
                pnThongKe.Location = new System.Drawing.Point(3, 371);

            }


        }
        //btnXUong
        private void button7_Click(object sender, EventArgs e)
        {
            btnLen.Visible = true;
            btnXuong.Visible = false;
            pnDanhMuc.Visible = false;
            if (pnThongKe.Visible == false)
            {
                pnXuong.Location = new System.Drawing.Point(3, 66);
                pictureBox1.Location = new System.Drawing.Point(3, 201);
            }
            else {

                pnXuong.Location = new System.Drawing.Point(3, 66);
                pictureBox1.Location = new System.Drawing.Point(3, 291);
                pnThongKe.Location = new System.Drawing.Point(3, 201);
            }
        }
        //Len
        private void button3_Click(object sender, EventArgs e)
        {
            btnThongkeLen.Visible = false;
            btnThonglkeXuong.Visible = true;
            pnThongKe.Visible = true;

            if (pnDanhMuc.Visible == false)
            {
                pictureBox1.Location = new System.Drawing.Point(3, 291);
                pnThongKe.Location = new System.Drawing.Point(3, 201);
            }
            else {
                pictureBox1.Location = new System.Drawing.Point(3, 471);
                pnThongKe.Location = new System.Drawing.Point(3, 371);
            }
        }
        //xuong
        private void button4_Click(object sender, EventArgs e)
        {
            pnThongKe.Visible = false;
            btnThongkeLen.Visible = true;
            btnThonglkeXuong.Visible = false;
            if (pnDanhMuc.Visible == false)
            {
                pictureBox1.Location = new System.Drawing.Point(3, 201);
                pnThongKe.Location = new System.Drawing.Point(3, 201);
            }
            else
            {
                pictureBox1.Location = new System.Drawing.Point(3, 381);
                pnThongKe.Location = new System.Drawing.Point(3, 371);
            }
        }
        //show form

        //Mo form quan ly diem
        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
           // tabControl1.SelectedIndex = 0;
            if (Application.OpenForms["QuanLyDiem"] as QuanLyDiem == null)
            {
               
                
               
                qlDiem.MAGV = MAGV;
                qlDiem.Show();
               

            }
            
                Them(qlDiem);            
        }
        //tao
        
        //su kien dong
        private void Them(Form a)
        {
            foreach (Control item in BaoForm.Controls.OfType<Form>())
            {


                item.Dock = DockStyle.None;
                BaoForm.Controls.Remove(item);
                   
                
            }
            a.TopLevel = false;
            a.AutoScroll = true;
            a.FormBorderStyle = FormBorderStyle.None;
            
            a.MdiParent = this;
            BaoForm.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }
        private void ClsQuanLyDiem_Click(object sender, EventArgs e)
        {
            if (pnDiem != null)
            {
                foreach (Control i in TabGG.Controls.OfType<Panel>())
                    if (i == pnDiem)
                    {
                        
                        TabGG.Controls.Remove(i);
                        pnDiem = null;
                        disQuanLyDiem = null;
                        clsQuanLyDiem = null;

                        break;
                    }
            }



            foreach (Form item in this.MdiChildren)
            {
                
            }
               // frm.Close();
            //frm.Visible = false;
           // Application.Exit(QuanLyDiem);




            foreach (Control item in BaoFor.Controls.OfType<Form>())
                {
                    BaoForm.Controls.Remove(item);
                }
            
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            Them(qlMOnHoc);
            if (Application.OpenForms["QuanLyMonHoc"] as QuanLyMonHoc == null)
            {
                qlMOnHoc.Show();
            }
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            Them(qlLOp);
            if (Application.OpenForms["QuanLyLop"] as QuanLyLop == null)
            {
                qlLOp.Show();
            }
        }

        private void btnQuanLyHocSinh_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            Them(qlHocSinh);
            if (Application.OpenForms["frmHoSoHocSinh"] as frmHoSoHocSinh == null)
            {
                qlHocSinh.Show();
            }
        }
        //form load
        private void FormMain_Load(object sender, EventArgs e)
        {
          //  CanBoGiaoVienBLL c = new CanBoGiaoVienBLL();
           
            dos();
            tabControl1.SelectedIndex = 0;
           
            Them(hm);
            if (Application.OpenForms["home"] as home == null)
            {
                hm.Show();
            }
            btnThongkeLen.FlatStyle = FlatStyle.Flat;
            btnThongkeLen.FlatAppearance.BorderSize = 0;
            btnThongkeLen.BackColor = Color.White;

            btnThonglkeXuong.FlatStyle = FlatStyle.Flat;
            btnThonglkeXuong.FlatAppearance.BorderSize = 0;
            btnThonglkeXuong.BackColor = Color.White;

            btnLen.FlatStyle = FlatStyle.Flat;
            btnLen.FlatAppearance.BorderSize = 0;
            btnLen.BackColor = Color.White;

            btnXuong.FlatStyle = FlatStyle.Flat;
            btnXuong.FlatAppearance.BorderSize = 0;
            btnXuong.BackColor = Color.White;
            if (gv)
            {
                btnXuong.Enabled = false;
                btnLen.Enabled = false;
                btnThongkeLen.Enabled = false;
                btnThonglkeXuong.Enabled = false;
                btnQuanLyDanhMuc.Enabled = false;
                btnThongKeBaoCao.Enabled = false;
                btnPhanCongGiangDay.Enabled = false;
                int sl = tabControl1.TabPages.Count;
                for (int i=sl-1;i>0;i--)
                {
                    tabControl1.Controls.Remove(tabControl1.TabPages[i]);
                   // sl--;
                }
            }
            if (ad)
            {
                btnQuanLyDiem.Enabled = false;
            }
        }

        private void TabGG_Paint(object sender, PaintEventArgs e)
        {
           
        }

        
        private bool checkE(string name)
        {
            bool check = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        //Mo form Phan Cong giang day
        //tao
        private void Taodis(out Button na)
        {
            na = new Button();
            na.Width = 70;
            na.Height = 30;
            na.FlatStyle = FlatStyle.Flat;
            na.FlatAppearance.BorderSize = 0;
            if (na == disGiaoVien)
            {
                na.Text = "GiaoVien";
            }
            if (na == disLopHoc)
            {
                na.Text = "LopHoc";
            }
            if (na == disMonHoc)
            {
                na.Text = "MonHoc";
            }
            if (na == disPhanCong)
            {
                na.Text = "PhanCong";
            }
            if (na == disQuanLyDiem)
            {
                na.Text = "Diem";
            }
            if (na == disHocsinh)
            {
                na.Text = "HOcSinh";
            }
            if (na == disTkgiaovien)
            {
                na.Text = "TKGiaoVien";
            }
            if (na == disTkHocSinh)
            {
                na.Text = "tkHS";
            }
        }
        //cls
        private void Taocls(out Button  na)
        {
            na = new Button();
            na.Width = 30;
            na.Height = 30;
            na.FlatStyle = FlatStyle.Flat;
            na.FlatAppearance.BorderSize = 0;
            na.ForeColor = Color.Red;
            na.Text = "X";
        }
        //code bo di
        private void Taopn(out Panel pn)
        {
            pn = new Panel();
            pn.BorderStyle = BorderStyle.None;
            pn.BackColor = Color.White;
            pn.Width = 100;
            pn.Height = 30;
        }
        //lay ma gv
        string MAGV;
        private void dos (){
            CanBoGiaoVienBLL cb = new CanBoGiaoVienBLL();
            foreach (CanBoGiaoVien item in cb.dscb())
            {
                if (item.Taikhoan == TenUsers)
                {
                    doDucVinhToolStripMenuItem.Text = item.HoTen;
                    //QuanLyDiem f = new QuanLyDiem();
                    MAGV = item.MaCanBo;
                    break;
                }
            }
                  
                
            
        }
        //phancong
        private void btnPhanCongGiangDay_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
            if (Application.OpenForms["PhanCongGD"] as PhanCongGD == null)

                qlgd.Show();
            Them(qlgd);

        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
