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
    public partial class PhanCongGD : Form
    {
        public PhanCongGD()
        {
            InitializeComponent();
        }

        private void PhanCongGD_Load(object sender, EventArgs e)
        {
            GiangDayPCDABLL cls = new GiangDayPCDABLL();
            dgvGiangday.DataSource = cls.HienThiDS();
            dgvGiangday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
