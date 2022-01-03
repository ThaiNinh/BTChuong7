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
    public partial class frmkhachhang : Form
    {

        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string sql;
        DataTable tblKH;
        private void Load_DataGridView()
        {
          
            sql = "select * from tblKhach";
            tblKH = Funtions.GetDataToTable(sql);
            dataGridView1.DataSource = tblKH;
            Funtions.Runsql(sql);


        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            luu.Enabled = false;
            boqua.Enabled = false;
            makhach.Enabled = false;
            Load_DataGridView();
        }

        private void them_Click(object sender, EventArgs e)
        {
           
            xoa.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            boqua.Enabled = true;
            makhach.Enabled = true;
            makhach.Focus();
            them.Enabled = false;

        }


        private void luu_Click(object sender, EventArgs e)
        {
            if(makhach.Text == "")
            {
                MessageBox.Show("Vui long nhap ma!");
                makhach.Focus();
                return;
            }
            if (tenkhach.Text == "")
            {
                MessageBox.Show("VUI long nhap ten!");
                tenkhach.Focus();
                return;
            }
            if (diachi.Text == "")
            {
                MessageBox.Show("Vui long nhap dia chi!");
                diachi.Focus();
                return;
            }
            if (dienthoai.Text == "")
            {
                MessageBox.Show("VUi long nhap so dien thoai!");
                dienthoai.Focus();
                return;
            }
            sql = "select makhach from tblKhach where makhach= " + makhach.Text.Trim();
            if (Funtions.Checkey(sql))
            {
                MessageBox.Show("Ma khach da co vui long nhap lai!");
            }
            else
            {
                sql = "insert into tblKhach(makhach, tenkhach, diachi, dienthoai) values('" + makhach.Text + "',N'" + tenkhach.Text + "',N'" + diachi.Text + "','" + dienthoai.Text + "')";
                Funtions.Runsql(sql);
                Load_DataGridView();
                luu.Enabled = false;
                xoa.Enabled = true;
                sua.Enabled = true;
                makhach.Enabled = false;
                them.Enabled = true;
                boqua.Enabled = false;
                ResetValues();
            }
        }
        private void ResetValues()
        {
            makhach.Text = "";
            tenkhach.Text = "";
            diachi.Text = "";
            dienthoai.Text = "";
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu de sua!");
                return;
            }
            sql = "Update tblKhach set tenkhach = N'"+tenkhach.Text.Trim()+"', diachi =N'"+diachi.Text.Trim()+"', dienthoai ='"+dienthoai.Text.Trim()+"' where makhach ='"+makhach.Text.Trim()+"'";
            Funtions.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu!");
                return;
            }
            makhach.Text = dataGridView1.CurrentRow.Cells["mk"].Value.ToString();
            tenkhach.Text = dataGridView1.CurrentRow.Cells["tk"].Value.ToString();
            diachi.Text = dataGridView1.CurrentRow.Cells["dc"].Value.ToString();
            dienthoai.Text = dataGridView1.CurrentRow.Cells["dt"].Value.ToString();
            boqua.Enabled = true;
        }

        private void dataGridView1_Move(object sender, EventArgs e)
        {
           
        }

        private void frmkhachhang_Click(object sender, EventArgs e)
        {
         }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void boqua_Click(object sender, EventArgs e)
        {

            boqua.Enabled = false;
            them.Enabled = true;
            makhach.Enabled = false;
            ResetValues();
            xoa.Enabled = true;
            sua.Enabled = true;
        }
      
        private void xoa_Click(object sender, EventArgs e)
        {
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu de xoa!");
                return;
            }
            sql = "delete tblKhach where makhach = '"+makhach.Text.Trim()+"'";
            Funtions.RunsqlDel(sql);
            Load_DataGridView();
            ResetValues();
        }
    }
}
