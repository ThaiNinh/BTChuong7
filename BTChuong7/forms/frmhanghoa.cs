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
    public partial class frmhanghoa : Form
    {
        public frmhanghoa()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        DataTable tblHh;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "All file(*.*)|*.*|All files(*.*)|*.*";
            a.InitialDirectory = "F:\\Chuong7\\BTChuong7\\BTChuong7\\image1";
            a.Title = "mo file";
            
            a.FilterIndex = 1;
            if(a.ShowDialog() == DialogResult.OK)
            {
                anh.Image = Image.FromFile(a.FileName);
                anh.SizeMode = PictureBoxSizeMode.Zoom;
                file.Text = a.FileName;
            }
        }  
        string sql;
        private void Load_DataGridView()
        {
            
            sql = "select mahang,tenhang,machatlieu,soluong,dongianhap,dongiaban from tblHang";
            tblHh = Funtions.GetDataToTable(sql);
            dataGridView1.DataSource = tblHh;
        }

        private void frmhanghoa_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            mahang.Enabled = false;

            sql = "select machatlieu,tenchatlieu from tblChatlieu";
            Funtions.FIllcombo(sql, macl, "machatlieu", "tenchatlieu");
            macl.SelectedIndex = -1;
             ResetValues();
      
        
        }

        private void them_Click(object sender, EventArgs e)
        {
           
            mahang.Enabled = true;
            them.Enabled = false;
            xoa.Enabled = false;
            sua.Enabled = false;
            luu.Enabled = true;
            boqua.Enabled = true;
            tk.Enabled = false;
            hienthi.Enabled = false;
            mahang.Focus();

        }
        private void ResetValues()
        {
            mahang.Text = "";
            tenhang.Text = "";
            macl.Text = "";
            soluong.Text = "";
            gianhap.Text = "";
            giaban.Text = "";
            file.Text = "";
            anh.Image= null;
            ghichu.Text = "";
        }
        private void boqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            mahang.Enabled = false;
            them.Enabled = true;
            xoa.Enabled = true;
            sua.Enabled = true;
            tk.Enabled = true;
            hienthi.Enabled = true;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (mahang.Text == "")
            {
                MessageBox.Show("Chua nhap ma hang!");
                mahang.Focus();
                return;
            }
            if (tenhang.Text == "")
            {
                MessageBox.Show("Chua nhap ten!");
                tenhang.Focus();
                return;
            }
            if (macl.Text == "")
            {
                MessageBox.Show("Chua co ma chat lieu!");
                macl.Focus();
                return;
            }
            sql = "select mahang from tblHang where mahang = " + mahang.Text;
            if (Funtions.Checkey(sql))
            {
                MessageBox.Show("Da co ma hang nay!");
                return;
            }
            else {
                string ma;
                ma = "select machatlieu from tblChatlieu where tenchatlieu =" + macl.Text;
                sql = "insert into tblHang(mahang,tenhang,machatlieu,soluong,dongianhap,dongiaban,anh,ghichu) values " +
                    "('" + mahang.Text + "','" + tenhang.Text + "','"+macl.SelectedValue.ToString()+"','" + soluong.Text + "','" + gianhap.Text + "','" + giaban.Text + "','" + file.Text.Trim() + "','" + ghichu.Text + "')";
                Funtions.Runsql(sql);
                Load_DataGridView();
                ResetValues();
                them.Enabled = true;
                xoa.Enabled = true;
                sua.Enabled = true;
                tk.Enabled = true;
                hienthi.Enabled = true;
                mahang.Enabled = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblHh.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu!");
            }
            if(them.Enabled== false)
            {
                MessageBox.Show("Dang them du lieu!");
                return;
            }
            mahang.Text = dataGridView1.CurrentRow.Cells["mh"].Value.ToString();
            tenhang.Text = dataGridView1.CurrentRow.Cells["th"].Value.ToString();
            string ma = dataGridView1.CurrentRow.Cells["machatlieu"].Value.ToString();
            macl.Text = Funtions.GetFileValues("select tenchatlieu from tblChatlieu where machatlieu=" + ma);
       
            soluong.Text = dataGridView1.CurrentRow.Cells["soluong1"].Value.ToString();
            giaban.Text = dataGridView1.CurrentRow.Cells["dongiaban"].Value.ToString();
            gianhap.Text = dataGridView1.CurrentRow.Cells["dongianhap"].Value.ToString();
            file.Text = Funtions.GetFileValues("select anh from tblHang where mahang = '"+mahang.Text+"'" );
            anh.Image = Image.FromFile(file.Text);
            anh.SizeMode = PictureBoxSizeMode.Zoom;
            ghichu.Text = Funtions.GetFileValues("select ghichu from tblHang where mahang ='" + mahang.Text + "'");
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if(them.Enabled== false)
            {
                MessageBox.Show("Dang them du lieu!");
                return;
            }
            if (mahang.Text == "")
            {
                MessageBox.Show("Vui long chon du lieu!");
                return;
            }
          
            
            sql = " delete tblHang where mahang = '" + mahang.Text + "'";
            Funtions.RunsqlDel(sql);
            Load_DataGridView();
            ResetValues();

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if(them.Enabled== false)
            {
                MessageBox.Show("Dang them  du lieu!");
                return;
            }
            if (mahang.Text == "")
            {
                MessageBox.Show("ban chua chon du lieu!");
                return;
            }
            sql = "Update tblHang set tenhang = '"+tenhang.Text+"',machatlieu='"+macl.SelectedValue.ToString()+"',soluong ='"+soluong.Text+"',dongianhap='"+gianhap.Text+"',dongiaban='"+giaban.Text+"',anh='"+file.Text+"',ghichu='' where mahang ='"+mahang.Text+"' ";
            Funtions.Runsql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void tk_Click(object sender, EventArgs e)
        {
            if(mahang.Text=="" && tenhang.Text=="" && macl.Text == "")
            {
                MessageBox.Show("Vui long nhap 1 du lieu de tim kiem!");
                return;
            }
            sql = "select * from tblHang where 1=1 ";
            if(mahang.Text != "")
            {
                sql = sql + "AND mahang LIKE '%" + mahang.Text+"%'";
            }
            if ( tenhang.Text!="")
            {
                sql = sql + " AND tenhang LIKE N'%"+tenhang.Text+"%'" ;
            }
            if (macl.Text != "")
            {
                sql = sql + " AND machatlieu LIKE " +"'%"+ macl.SelectedValue.ToString()+"%'";
            }
            tblHh = Funtions.GetDataToTable(sql);
            if (tblHh.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu nao!");
            }
            dataGridView1.DataSource = tblHh;
            ResetValues();

        }

        private void hienthi_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void anh_Click(object sender, EventArgs e)
        {

        }

        private void macl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mahang_DoubleClick(object sender, EventArgs e)
        {
            mahang.Enabled = true;
        }
    }
}
