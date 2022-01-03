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

    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
            nam.Checked = true;

        }
        DataTable tblNV;
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            manhanvien.Enabled = false;
            luu.Enabled = false;
            boqua.Enabled = false;
            Load_DataGridView();
            Gtinh.Enabled = false;

            
        }
        private void Load_DataGridView()
        {
         
            sql = "select * from tblNhanvien";
            tblNV = Funtions.GetDataToTable(sql);
            dataGridView1.DataSource = tblNV;
        }
        public void ResetValues()
        {
            manhanvien.Text = "";
            tennhanvien.Text = "";
            diachi.Text = "";
            ns.Value = DateTime.Today;
            sdt.Text = "____ ____ ____";

        }
        private void them_Click(object sender, EventArgs e)
        {
            manhanvien.Enabled = true;
            manhanvien.Focus();
            sua.Enabled = false;
            xoa.Enabled = false;
            luu.Enabled = true;
            boqua.Enabled = true;
            Gtinh.Enabled = true;
        }
        
        private void nam_CheckedChanged(object sender, EventArgs e)
        {
            nam.Checked = true;
            nu.Checked = false;
            gioitinh = "Nam";
        }

        private void nu_CheckedChanged(object sender, EventArgs e)
        {
            nam.Checked = false;
            nu.Checked = true ;
            gioitinh = "Nu";
        }
         string gioitinh;
        private void luu_Click(object sender, EventArgs e)
        {
            if (manhanvien.Text == "")
            {
                MessageBox.Show("Vui long nhap ma nhan vien!");
                manhanvien.Focus();
                return;
            }
            if (tennhanvien.Text == "")
            {
                MessageBox.Show("Vui long nhap ten nhan vien!");
                tennhanvien.Focus();
                return;
            }
            if (diachi.Text == "")
            {
                MessageBox.Show("Vui long nhap dia chi!");
                diachi.Focus();
                return;
            }
            if(nam.Checked== true)
            {
                gioitinh = "Nam";
            }
            if(nu.Checked== true)
            {
                gioitinh = "Nữ";
            }
            if (Funtions.IsDate(ns.Text) == false)
            {
                MessageBox.Show("Vui long nhap lai ngay sinh!");
            }
            string sql;
            sql = "select manhanvien from tblNhanvien where manhanvien ='" + manhanvien.Text.Trim()+ "'";
            if (Funtions.Checkey(sql)== true)
            {
                MessageBox.Show("du lieu da co vui long nhap lai ma nhan vien!");
                manhanvien.Focus();
                manhanvien.Text = "";
                return;
            }
            else
            {
                sql = "Insert into tblNhanvien(manhanvien,tennhanvien,gioitinh,diachi,dienthoai,ngaysinh) Values('" + manhanvien.Text.Trim() + "',N'" + tennhanvien.Text + "',N'" + gioitinh + "',N'" + diachi.Text + "','" + sdt.Text + "','" + Funtions.CovertToDate(ns.Text)+"')";
                Funtions.Runsql(sql);
                Load_DataGridView();
                ResetValues();
                manhanvien.Enabled = false;
                them.Enabled = true;
                sua.Enabled = true;
                xoa.Enabled = true;
                luu.Enabled = false;
                boqua.Enabled = false;
            }
        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void groupBox1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sdt_MouseDown(object sender, MouseEventArgs e)
        {
            if (sdt.Text == "____ ____ ____")
            {
                sdt.Text = "";
            }
        }

        private void sdt_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void sdt_MouseMove(object sender, MouseEventArgs e)
        {
 
        }

        private void sdt_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void ns_MouseDown(object sender, MouseEventArgs e)
        {
            if (ns.Text == "____/_____/_____")
            {
                ns.Text = "";
            }
        }
     string sql;
        private void xoa_Click(object sender, EventArgs e)
        {
       
            if(tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu de xoa!");
            }
            if (manhanvien.Text == "")
            {
                MessageBox.Show("VUi long chon nhan vien can xoa!");
            }
            sql = " delete tblNhanvien where manhanvien =" + manhanvien.Text.ToString();
            Funtions.RunsqlDel(sql);
            Load_DataGridView();
            ResetValues();
            MessageBox.Show("Xoa thanh cong!");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(them.Enabled == false)
            {
                MessageBox.Show("Dang them du lieu!");
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu !");
                return;
            }
            manhanvien.Text = dataGridView1.CurrentRow.Cells["mnv"].Value.ToString();
            tennhanvien.Text = dataGridView1.CurrentRow.Cells["tnv"].Value.ToString();
            diachi.Text = dataGridView1.CurrentRow.Cells["dc"].Value.ToString();
            sdt.Text = dataGridView1.CurrentRow.Cells["dt"].Value.ToString();
            ns.Value = (DateTime)dataGridView1.CurrentRow.Cells["ngaysinh"].Value;
            if(dataGridView1.CurrentRow.Cells["gt"].Value.ToString() == "Nam")
            {
                nam.Checked = true;
            }
            if(dataGridView1.CurrentRow.Cells["gt"].Value.ToString() == "Nữ")
            {
                nu.Checked = true;
            }
            Gtinh.Enabled = true;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu!");
            }
            if (manhanvien.Text == "")
            {
                MessageBox.Show("Vui long chon nhan vien can sua!");
                return;
            }
            if (nam.Checked == true)
            {   
                gioitinh = "Nam";
            }
            if (nu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            sql = "UPDATE tblNhanvien SET tennhanvien=N'" + tennhanvien.Text.Trim().ToString() + "',gioitinh=N'" + gioitinh + "',diachi=N'" + diachi.Text.Trim().ToString() + "',ngaysinh='" + Funtions.CovertToDate(ns.Text) + "',dienthoai='" + sdt.Text.ToString() + "' where manhanvien =N'"+manhanvien.Text+"'";
            Funtions.Runsql(sql);
            Load_DataGridView();
            MessageBox.Show("Sua du lieu thanh cong!");
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tennhanvien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
