using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BTChuong7
{
    public partial class frmChatlieu : Form
    {
        public frmChatlieu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView.ReadOnly = true;
        }
           DataTable tblCL;
        private void them_Click(object sender, EventArgs e)
        {
            sua.Enabled = false;
            xoa.Enabled = false;
            boqua.Enabled = true;
            luu.Enabled = true;
            them.Enabled = false;
            ResetValues();
            machatlieu.Enabled = true;
            machatlieu.Focus();

        }
        private void ResetValues()
        {
            machatlieu.Text = "";
            tenchatlieu.Text = "";
        }
        private void frmChatlieu_Load(object sender, EventArgs e)
        {
            machatlieu.Enabled = false;
            boqua.Enabled = false;
            luu.Enabled = false;
            Load_DataGridView();
        }
     
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT machatlieu, tenchatlieu FROM tblChatlieu";
            tblCL = Funtions.GetDataToTable(sql);

            DataGridView.DataSource = tblCL;
            Funtions.Runsql(sql);
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
           
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (them.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi!");
                machatlieu.Focus();
                return;
            }
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu");
                return;
            }
            machatlieu.Text = DataGridView.CurrentRow.Cells["macl"].Value.ToString();
            tenchatlieu.Text = DataGridView.CurrentRow.Cells["tencl"].Value.ToString();
            sua.Enabled = true;
            xoa.Enabled = true;
            boqua.Enabled = true;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (machatlieu.Text == "")
            {
                MessageBox.Show("ban phai nhap ma chat lieu", "thong bao");
                machatlieu.Focus();
                return;
            }
            if (tenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("ban phai nhap ten chat lieu");
                tenchatlieu.Focus();
                return;
            }
            sql = $"SELECT machatlieu FROM tblChatlieu WHERE machatlieu = '{machatlieu.Text.Trim()}'";
            if (Funtions.Checkey(sql))
            {
                MessageBox.Show("ma nay da co, ban phia nhap ma khac");
                machatlieu.Focus();
                machatlieu.Text = "";
                return;
            }
            else
            {
                sql = "INSERT INTO tblChatlieu(machatlieu, tenchatlieu) VALUES(N'"+machatlieu.Text.Trim()+"',N'"+tenchatlieu.Text.Trim()+"')";
                Funtions.Runsql(sql);
                Load_DataGridView();
                ResetValues();
                xoa.Enabled = true;
                them.Enabled = true;
                sua.Enabled = true;
                boqua.Enabled = false;
                luu.Enabled = false;
                machatlieu.Enabled = false;
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (machatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenchatlieu.Focus();
                return;
            }
            sql = "UPDATE tblChatlieu SET Tenchatlieu=N'" + tenchatlieu.Text.ToString() +
"' WHERE Machatlieu=N'" + machatlieu.Text + "'";
           Funtions.Runsql(sql);
            Load_DataGridView();
            ResetValues();
            boqua.Enabled = false;

        }

        private void boqua_Click(object sender, EventArgs e)
        {
            boqua.Enabled = false;
            them.Enabled = true;
            machatlieu.Enabled = false;
            ResetValues();
            xoa.Enabled = true;
            sua.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu!");
                return;
            }
            if (machatlieu.Text == "")
            {
                MessageBox.Show("Vui long chon hang can xoa!");
                return;
            }
            if(MessageBox.Show("Ban co muon xoa khong!","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                sql = "delete tblChatlieu where machatlieu =N'" + machatlieu.Text + "'";
                Funtions.RunsqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
