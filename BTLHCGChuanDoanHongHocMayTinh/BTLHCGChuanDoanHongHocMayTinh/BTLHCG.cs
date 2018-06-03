using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHCGChuanDoanHongHocMayTinh
{
    public partial class BTLHCG : Form
    {
        public BTLHCG()
        {
            InitializeComponent();
        }
        PhanCungMayTinhPublic x = new PhanCungMayTinhPublic();


        public DataTable DataMain()
        {
            DataTable dtmain = new DataTable();
            dtmain.Columns.Add("DenNguon",typeof(bool));
            dtmain.Columns.Add("ManHinh", typeof(bool));
            dtmain.Columns.Add("QuatNguon", typeof(bool));
            dtmain.Columns.Add("HDH", typeof(bool));
            dtmain.Columns.Add("BipBIOS", typeof(int));
            dtmain.Columns.Add("Ketqua", typeof(string));

            dtmain.Rows.Add(false, false, false, false, 0,"Lỗi Nguồn");
            dtmain.Rows.Add(true, false, true, true, 1, "Lỗi Màn Hình");
            dtmain.Rows.Add(true, false, true, true, 2, "Lỗi TB Xử Lí");
            dtmain.Rows.Add(true, true, true, false, 1, "Lỗi Dữ Liệu");
            return dtmain;
        }
        DataTable dtBios = new DataTable();
        private void BTLHCG_Load(object sender, EventArgs e)
        {
            dtBios.Columns.Add("Text", typeof(string));
            dtBios.Columns.Add("Get", typeof(string));
            dtBios.Columns.Add("Ketqua", typeof(string));

            dtBios.Rows.Add("Tiếng Bip Dạng 1_1_3", "113", "Lỗi CMOS");
            dtBios.Rows.Add("Tiếng Bip Dạng 1_1_4", "114", "Lỡi BIOS");
            dtBios.Rows.Add("Tiếng Bip Dạng 1_2_1", "121", "Lỗi ClockChip MainBoard");
            dtBios.Rows.Add("Tiếng Bip Dạng 1_3_1", "131", "Hỏng Mainboard");
            dtBios.Rows.Add("Tiếng Bip Dạng 1_4_2", "142", "Lỗi khe RAM");
            dtBios.Rows.Add("Tiếng Bip Dạng 2_0_0", "200", "Lỗi RAM");
            dtBios.Rows.Add("Tiếng Bip Dạng 3_2_4", "324", "Lỗi Keyboard test chip");
            dtBios.Rows.Add("Tiếng Bip Dạng 3_3_4", "334", "Lỗi khe VGA");
            dtBios.Rows.Add("Tiếng Bip Dạng 3_4_0", "340", "Lỗi VGA");
            dtBios.Rows.Add("Tiếng Bip Dạng 4_2_4", "424", "Lỗi Card on Mainboard");
            dtBios.Rows.Add("Tiếng Bip Dạng 4_3_4", "434", "Lỗi pin CMOS");
            dtBios.Rows.Add("Tiếng Bip Dạng 4_4_1", "441", "Lỗi Serial port");
            dtBios.Rows.Add("Tiếng Bip Dạng 4_4_2", "442", "Lỗi Paralel port");
            dtBios.Rows.Add("Tiếng Bip Dạng 4_4_3", "443", "Lỗi CPU");
            DataTable dtcbo = new DataTable();
            dtcbo.Columns.Add("Text", typeof(string));
            dtcbo.Columns.Add("Get", typeof(string));
            dtcbo.Rows.Add("Có", "1");
            dtcbo.Rows.Add("Không", "0");

            DataTable dtcbo1 = new DataTable();
            dtcbo1.Columns.Add("Text", typeof(string));
            dtcbo1.Columns.Add("Get", typeof(string));
            dtcbo1.Rows.Add("Có", "1");
            dtcbo1.Rows.Add("Không", "0");

            DataTable dtcbo3 = new DataTable();
            dtcbo3.Columns.Add("Text", typeof(string));
            dtcbo3.Columns.Add("Get", typeof(int));
            dtcbo3.Rows.Add("Có", "1");
            dtcbo3.Rows.Add("Không", "0");

            DataTable dtcbo4 = new DataTable();
            dtcbo4.Columns.Add("Text", typeof(string));
            dtcbo4.Columns.Add("Get", typeof(string));
            dtcbo4.Rows.Add("Có", "1");
            dtcbo4.Rows.Add("Không", "0");

            DataTable dtcbo2 = new DataTable();
            dtcbo2.Columns.Add("Text", typeof(string));
            dtcbo2.Columns.Add("Get", typeof(int));
            dtcbo2.Rows.Add("Không có", 0);
            dtcbo2.Rows.Add("Ngắn", 1);
            dtcbo2.Rows.Add("Dài", 2);

            cboDenNguon.DataSource = dtcbo;
            cboDenNguon.DisplayMember = "Text";
            cboDenNguon.ValueMember = "Get";

            cboManHinh.DataSource = dtcbo1;
            cboManHinh.DisplayMember = "Text";
            cboManHinh.ValueMember = "Get";

            cboQuatNguon.DataSource=dtcbo3;
            cboQuatNguon.DisplayMember = "Text";
            cboQuatNguon.ValueMember = "Get";

            cboHDH.DataSource=dtcbo4;
            cboHDH.DisplayMember = "Text";
            cboHDH.ValueMember = "Get";

            cboBipBios.DataSource=dtcbo2;
            cboBipBios.DisplayMember = "Text";
            cboBipBios.ValueMember = "Get";

            DataTable dtLoiNguon = new DataTable();
            dtLoiNguon.Columns.Add("Text", typeof(string));
            dtLoiNguon.Columns.Add("Get", typeof(string));
            dtLoiNguon.Rows.Add("Lỏng", "1");
            dtLoiNguon.Rows.Add("Không lỏng", "0");
            cboLoiNguon.DataSource = dtLoiNguon;
            cboLoiNguon.DisplayMember = "Text";
            cboLoiNguon.ValueMember = "Get";

            DataTable dtCapNguon = new DataTable();
            dtCapNguon.Columns.Add("Text", typeof(string));
            dtCapNguon.Columns.Add("Get", typeof(string));
            dtCapNguon.Rows.Add("Hoạt động", "1");
            dtCapNguon.Rows.Add("Không hoạt động", "0");
            cboNutDieuKhien.DataSource = dtCapNguon;
            cboNutDieuKhien.DisplayMember = "Text";
            cboNutDieuKhien.ValueMember = "Get";

        }
        int flag = -1;
        private void btnLoiChinh_Click(object sender, EventArgs e)
        {
            if (cboDenNguon.SelectedValue.ToString()=="0" && cboManHinh.SelectedValue.ToString()=="0" &&cboQuatNguon.SelectedValue.ToString()=="0"&&cboHDH.SelectedValue.ToString()=="0" &&cboBipBios.SelectedValue.ToString()=="0")
            {
                lblLoi.Text = "Máy tính của bạn bị lỗi nguồn";
                flag = 0;
            }
            else if (cboDenNguon.SelectedValue.ToString()=="1" && cboManHinh.SelectedValue.ToString()=="0" &&cboQuatNguon.SelectedValue.ToString()=="1"&&cboHDH.SelectedValue.ToString()=="1" &&cboBipBios.SelectedValue.ToString()=="1")
            {
                lblLoi.Text = "Máy tính của bạn bị lỗi Màn hình";
                flag = 1;
            }
            else if (cboDenNguon.SelectedValue.ToString() == "1" && cboManHinh.SelectedValue.ToString() == "0" && cboQuatNguon.SelectedValue.ToString() == "1" && cboHDH.SelectedValue.ToString() == "1" && cboBipBios.SelectedValue.ToString() == "2")
            {
                lblLoi.Text = "Máy tính của bạn bị lỗi Thiết bị xử lí";
                flag = 2;
            }
            else if (cboDenNguon.SelectedValue.ToString() == "1" && cboManHinh.SelectedValue.ToString() == "1" && cboQuatNguon.SelectedValue.ToString() == "1" && cboHDH.SelectedValue.ToString() == "0" && cboBipBios.SelectedValue.ToString() == "1")
            {
                lblLoi.Text = "Máy tính của bạn bị lỗi Dữ liệu";
                flag = 3;
            }
            else
            {
                MessageBox.Show("Máy tính bạn hoàn toàn bình thường!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (flag==0)
            {
                cboLoiNguon.Visible = true;
                lblLoiNguon.Text = "Kiểm tra cáp nguồn";
                lblLoiChiTiet.Text = "";
                cboNutDieuKhien.Visible = false;
            }
            else if (flag==1)
            {
                lblLoiNguon.Text = "Kiểm tra: Cáp tín hiệu Màn hình";
                lblLoiChiTiet.Text = " Kiểm tra: Nút điều khiển";
                cboNutDieuKhien.Visible = true;
                cboLoiNguon.Visible = true;
            }
            else if (flag==2)
            {
                cboLoiNguon.DataSource = dtBios;
                cboLoiNguon.DisplayMember = "Text";
                cboLoiNguon.ValueMember = "Get";
                lblLoiNguon.Text = "Kiểm tra: Thiết bị xử lí";
                lblLoiChiTiet.Text = "";
                cboNutDieuKhien.Visible = false;
                cboLoiNguon.Visible = true;
            }
            else
            {
                lblLoiNguon.Text = "Kiểm tra: Ổ cứng";
                lblLoiChiTiet.Text = "Kiểm tra: Cáp dữ liệu";
                cboNutDieuKhien.Visible = true;
                cboLoiNguon.Visible = true;
            }
        
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BTLHCG_Load(sender, e);
            lblLoi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 0:
                    if (cboLoiNguon.SelectedValue.ToString()=="1")
                    {
                        lblKetQua.Text = "Máy tính lỏng cáp nguồn";
                    }
                    else
                    {
                        lblKetQua.Text = "Bộ nguồn máy tính cháy";
                    }
                    break;
                case 1:
                    
                    if (cboLoiNguon.SelectedValue.ToString()=="1")
                    {
                        lblKetQua.Text = "Máy tính lỏng cáp màn hình";
                    }
                    else
                    {
                        if (cboNutDieuKhien.SelectedValue.ToString() == "1")
                        {
                            lblKetQua.Text = "Máy tính hỏng màn hình";
                        }
                        else
                        {
                            lblKetQua.Text = "Máy tính hỏng nút điều khiển";
                        }
                    }
                    break;
                case 2:
                    int t = 0;
                    for (int i = 0; i < 14; i++)
                    {

                            if (cboLoiNguon.SelectedValue.ToString() == dtBios.Rows[i][1].ToString())
                            {
                                t = i;
                                break;
                            }
                    }
                    lblKetQua.Text = "Máy tính bạn bị " + dtBios.Rows[t][2].ToString();
                    break;
                case 3:
                    if (cboLoiNguon.SelectedValue.ToString()=="0")
                    {
                        lblKetQua.Text = "Máy tính bị lỗi, hỏng hệ điều hành";
                    }
                    if (cboLoiNguon.SelectedValue.ToString()=="1" && cboNutDieuKhien.SelectedValue.ToString()=="1")
                    {
                        lblKetQua.Text = "Máy tính bị lỏng cáp dữ liệu";
                    }
                    if (cboLoiNguon.SelectedValue.ToString()=="1" && cboNutDieuKhien.SelectedValue.ToString()=="0")
                    {
                        lblKetQua.Text = "Máy tính bị hỏng hệ điều hành";
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
