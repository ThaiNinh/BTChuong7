using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTChuong7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
          private void Form1_Load(object sender, EventArgs e)
            {
            Funtions.Connect();
            }
        private void chatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatlieu a = new frmChatlieu();

            a.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funtions.Disconnect();
            Application.Exit();

            Application.Exit();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien a = new frmnhanvien();
            a.ShowDialog();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang a = new frmkhachhang();
            a.Show();
        }

        private void hoaDonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmhanghoa a = new frmhanghoa();
            a.Show();
        }

        private void hoaDonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDBan a = new frmHDBan();
            a.Show();
        }
    }
}
    