using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using COMExel = Microsoft.Office.Interop.Excel;

namespace BTChuong7
{
    public partial class frmHDBan : Form
    {
        public frmHDBan()
        {
            InitializeComponent();
        }
        DataTable tblhbban;

        private void frmHDNhap_Load(object sender, EventArgs e)
        {
           
            mahoadon.Enabled = false;
            manhanvien.Enabled = false;
            makhachhang.Enabled = false;
            makhachhang.Enabled = false;
            tennhanvien.Enabled = false;
            tenkhach.Enabled = false;
            diachi.Enabled = false;
            dienthoai.Enabled = false;
            tenhang.Enabled = false;
            dongia.Enabled = false;
            thanhtien.Enabled = false;
            mahang.Enabled = false;
            thanhtien.Text = "0";
            tongtien.Text = "0";
            luu.Enabled = false;
            tongtien.Enabled = false;
            sql = "select manhanvien,tennhanvien from tblNhanvien";
            Funtions.FIllcombo(sql, manhanvien, "manhanvien", "manhanvien");
            manhanvien.SelectedIndex = -1;
            sql = "select makhach, tenkhach from tblKhach";
            Funtions.FIllcombo(sql, makhachhang, "makhach", "makhach");
            makhachhang.SelectedIndex = -1;
            sql = "select mahang,tenhang from tblHang";
            Funtions.FIllcombo(sql, mahang, "mahang", "mahang");
            mahang.SelectedIndex = -1;
            sql = " select maHDBan from tblHDBan";
            Funtions.FIllcombo(sql, cbotim, "maHDBan", "maHDBan");
            cbotim.SelectedIndex = -1;
            if (mahoadon.Text != "")
            {
                Load_ThongtinHD();
                IN.Enabled = true;
            } 

        }
        string sql;
        private void Load_DataGridView()
        {
           
            sql = "select tblchitietHDBan.mahang, tenhang, tblchitietHDBan.soluong, dongia, giamgia, thanhtien from tblchitietHDBan inner join tblHang on tblchitietHDBan.mahang = tblHang.mahang where maHDBan ='"+mahoadon.Text+"'";
            tblhbban = Funtions.GetDataToTable(sql);
            dataGridView1.DataSource = tblhbban;
            dataGridView1.Columns[0].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].HeaderText = "Tên hàng";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Giảm giá %";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }
        private void resetVales()
        {
            mahoadon.Text = "";
            ngayban.Text = DateTime.Today.ToString();
            manhanvien.Text = "";
            tennhanvien.Text = "";
            makhachhang.Text = "";
            tenkhach.Text = "";
            diachi.Text = "";
            dienthoai.Text = "";
            mahang.Text = "";
            tenhang.Text = "";
            dongia.Text = "";
            soluong.Text = "";
            giamgia.Text = "";
            thanhtien.Text = "0";
            tongtien.Text = "0";
        }
        private void them_Click(object sender, EventArgs e)
        {
            resetVales();
            ResetValuesHang();
            luu.Enabled = true;
            them.Enabled = false;
            manhanvien.Enabled = true;
            makhachhang.Enabled = true;
            mahang.Enabled = true;
            mahoadon.Text = Funtions.CreateKey("HDB");
            Load_DataGridView();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
            {
                string[] ma= new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "select mahang from tblchitietHDBan where maHDBan = '" + mahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Funtions.con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ma[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                for (i = 0; i < n; i++)
                {
                    DelHang(mahoadon.Text, ma[i]);
                    
                }
                sql = "delete tblHDBan where maHDBan = '" + mahoadon.Text + "'";
                Funtions.RunsqlDel(sql);

                them.Enabled = true;
                luu.Enabled = false;
                manhanvien.Enabled = false;
                makhachhang.Enabled = false;
                mahang.Enabled = false;
                resetVales();
                ResetValuesHang();

            }
        }
        private void DelHang(string maHDBan, string mahang) 
        {
            Double s, sl, slCon;
            sql = " select tblchitietHDBan.soluong from tblchitietHDBan where maHDBan = '" + maHDBan + "' and mahang = '"+mahang+"'";
            s = Convert.ToDouble(Funtions.GetFileValues(sql));

            sql = "delete tblchitietHDBan  where maHDBan = '" + maHDBan + "' and mahang = '" + mahang + "'";
            Funtions.RunsqlDel(sql);

            // Cap nhat so luong

            sql = "select soluong from tblHang where mahang = '" + mahang + "'";
            sl = Convert.ToDouble(Funtions.GetFileValues(sql));
            slCon = s + sl;
            sql = "update tblHang set soluong = '" + slCon + "' where mahang = '"+mahang+"'";
            Funtions.Runsql(sql);
            sql = "select maHDBan from tblHDBan";
            Funtions.FIllcombo(sql, cbotim, "maHDBan", "maHDBan");
            cbotim.SelectedIndex = -1;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "select ngayban from tblHDBan where maHDBan =N'" + mahoadon.Text + "'";
            ngayban.Text = Funtions.GetFileValues(str);
            str = "select manhanvien from tblHDBan where maHDBan ='" + mahoadon.Text + "'";
            manhanvien.Text = Funtions.GetFileValues(str);
            str = "select makhach from tblHDBan where  maHDBan =N'" + mahoadon.Text + "'";
            makhachhang.Text = Funtions.GetFileValues(str);
            str = "SELECT tongtien FROM tblHDBan WHERE maHDBan = N'" + mahoadon.Text + "'";
            tongtien.Text = Funtions.GetFileValues(str);

            tienbangchu.Text = "Bằng chữ: " + Funtions.ChuyenSoSangChu(tongtien.Text);
        }
        private void luu_Click(object sender, EventArgs e)
        {
            double sl;
            sql = "select maHDBan from tblHDBan where maHDBan = '" + mahoadon.Text + "'";
            if (!Funtions.Checkey(sql))
            {
                if (ngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ngayban.Focus();
                    return;
                }
                if (manhanvien.Text == "")
                {
                    MessageBox.Show("vui long chon ma nhan vien!");
                    manhanvien.Focus();
                    return;
                }
                if (makhachhang.Text == "")
                {
                    MessageBox.Show("Vui long chon ma khach hang!");
                    makhachhang.Focus();
                    return;
                }
                sql = " Insert into tblHDBan(maHDBan,ngayban, manhanvien, makhach, tongtien) values('" + mahoadon.Text.Trim() + "','" + Funtions.CovertToDate(ngayban.Text) + "','" + manhanvien.SelectedValue + "','" + makhachhang.SelectedValue + "','" + tongtien.Text + "')";
                Funtions.Runsql(sql);
            }

            if (mahang.Text == "")
            {
                MessageBox.Show("Vui long nhap ma hang!");
                mahang.Focus();
                return;
            }
            if (soluong.Text == "")
            {
                MessageBox.Show("Chua co so luong!");
                soluong.Focus();
                return;
            }
            if (giamgia.Text == "")
            {
                MessageBox.Show("Duoc giam gia bao nhieu!");
                giamgia.Focus();
                return;
            }
            sql = "select soluong from tblHang where mahang = '" + mahang.Text.Trim() + "'";
            sl = Convert.ToDouble(Funtions.GetFileValues(sql));
            if (Convert.ToDouble(soluong.Text) > sl)
            {
                MessageBox.Show("So long trong kho khong du vui long chon so luong < '" + sl.ToString() + "'");
                soluong.Focus();
                return;
            }

            sql = "select mahang from tblchitietHDBan where mahang ='" + mahang.SelectedValue + "'And maHDBan = '" + mahoadon.Text + "'";
            if (Funtions.Checkey(sql))
            {
                MessageBox.Show("maangnay da c0");
                ResetValuesHang();
                mahang.Focus();
                return;
            }

            sl = Convert.ToDouble(Funtions.GetFileValues("select soluong from tblHang where mahang = '" + mahang.SelectedValue + "'"));
            if (Convert.ToDouble(soluong.Text) > sl)
            {
                MessageBox.Show("so luong mat hang nay chi con " + sl);
                soluong.Text = "";
                soluong.Focus();
                return;
            }
            sql = "insert into tblchitietHDBan(maHDBan,mahang,soluong,dongia,giamgia,thanhtien) values (" +
                "'" + mahoadon.Text + "','" + mahang.SelectedValue + "','" + soluong.Text + "','" + dongia.Text + "','" + giamgia.Text + "','" + thanhtien.Text + "')";
            Funtions.Runsql(sql);
            Load_DataGridView();

            // cap nhat so luong mat hang nay
            double SLCon;
            SLCon = sl - Convert.ToDouble(soluong.Text);
            sql = "update tblHang set soluong = '" + SLCon + "' where mahang = '" + mahang.Text + "'";
            Funtions.Runsql(sql);
            // tong
            double tong, tongmoi;
            tong = Convert.ToDouble(Funtions.GetFileValues("select tongtien from tblHDBan where maHDBan = '" + mahoadon.Text + "'"));
            tongmoi = tong + Convert.ToDouble(thanhtien.Text);
            sql = "update tblHDBan set tongtien = '" + tongmoi + "' where maHDBan = '"+mahoadon.Text+"'";
            Funtions.Runsql(sql);
            tongtien.Text = tongmoi.ToString();
            ResetValuesHang();
            IN.Enabled = true;
            sql = " select maHDBan from tblHDBan";
            Funtions.FIllcombo(sql, cbotim, "maHDBan", "maHDBan");
            cbotim.SelectedIndex = -1;
            if (mahoadon.Text != "")
            {
                Load_ThongtinHD();
                IN.Enabled = true;
            }
            them.Enabled = true;

        }
        private void ResetValuesHang()
        {
            mahang.Text = "";
            soluong.Text = "";
            giamgia.Text = "0";
            thanhtien.Text = "0";

        }

        private void manhanvien_Click(object sender, EventArgs e)
        {
        }

        private void manhanvien_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void manhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (manhanvien.Text == "")
            {
                tennhanvien.Text = "";
            }
            else{ 
            str = "select tennhanvien from tblNhanvien where manhanvien = N'" + manhanvien.SelectedValue + "'";
            tennhanvien.Text = Funtions.GetFileValues(str);}
        }

        private void makhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void makhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (makhachhang.Text == "")
            {
                tenkhach.Text = "";
                diachi.Text = "";
                dienthoai.Text = "";
            }
            else
            {
                str = "select tenkhach from tblKhach where makhach = '"+makhachhang.SelectedValue+"'" ;
                tenkhach.Text = Funtions.GetFileValues(str);
                str = "select diachi from tblKhach where makhach =  '" + makhachhang.SelectedValue + "'";
                diachi.Text = Funtions.GetFileValues(str);
                str = "select dienthoai from tblKhach where makhach =  '" + makhachhang.SelectedValue + "'";
                dienthoai.Text = Funtions.GetFileValues(str);

            }
        }

        private void mahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (mahang.Text == "")
            {
                tenhang.Text = "";
                dongia.Text = "";
            }
            else
            {
                str = "select tenhang from tblHang where mahang = '" + mahang.SelectedValue + "'";
                tenhang.Text = Funtions.GetFileValues(str);
                str = "select dongiaban from tblHang where mahang = '" + mahang.SelectedValue + "'";
                dongia.Text = Funtions.GetFileValues(str);

            }
        }

        private void soluong_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg, tt;
            if (soluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToDouble(soluong.Text);
            }
            if(giamgia.Text== "")
            {
                gg = 0;

            }
            else
            {
                gg = Convert.ToDouble(giamgia.Text);
            }
            if (dongia.Text == "")
            {
                tt = 0;
            }
            else
            {
                dg = Convert.ToDouble(dongia.Text);
                tt = dg * sl - dg * gg * sl / 100;
                thanhtien.Text = tt.ToString();
            }
            
        }

        private void giamgia_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg, tt;
            if (soluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToDouble(soluong.Text);
            }
            if (giamgia.Text == "")
            {
                gg = 0;

            }
            else
            {
                gg = Convert.ToDouble(giamgia.Text);
            }
            if (dongia.Text == "")
            {
                tt = 0;
            }
            else
            {
                dg = Convert.ToDouble(dongia.Text);
                tt = dg * sl - dg * gg * sl / 100;
                thanhtien.Text = tt.ToString();
            }

        }

        private void tongtien_TextChanged(object sender, EventArgs e)
        { 
        }

        private void tienbangchu_TextChanged(object sender, EventArgs e)
        {
            string tt;
            tt = tongtien.Text;
            tienbangchu.Text = "bang chu: '" + Funtions.ChuyenSoSangChu(tt) + "'";
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            
            mahoadon.Text = cbotim.SelectedValue.ToString();
            Load_ThongtinHD();
            
            Load_DataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IN_Click(object sender, EventArgs e)
        {
            COMExel.Application exApp = new COMExel.Application();

            COMExel.Workbook exBook;
            COMExel.Worksheet exSheet;
            COMExel.Range exRange;
            int hang = 0,  cot = 0; ;
            DataTable tblThongtinHD, ThongtinHang;
            exBook = exApp.Workbooks.Add(COMExel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop Lâm Anh";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "select a.maHDBan, a.ngayban, a.tongtien, b.tenkhach, b.diachi, b.dienthoai,c.tennhanvien from tblHDBan AS a, tblKhach AS b, tblNhanvien AS c where a.maHDBan = '" + mahoadon.Text + "' and a.makhach = b.makhach and a.manhanvien = c.manhanvien ";

            tblThongtinHD = Funtions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.tenhang, a.soluong, b.dongiaban, a.giamgia, a.thanhtien " +
                  "FROM tblChitietHDBan AS a , tblHang AS b WHERE a.maHDBan = N'" +
                  mahoadon.Text + "' AND a.mahang = b.mahang";
            ThongtinHang = Funtions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= ThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= ThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = ThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Funtions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }

        private void dong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co muon dong?","thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void DelUpdateTongTien(string mahoadon, double thanhtien)
        {
            double tong, tongmoi;
            sql = "select tongtien from tblHDBan where maHDBan = '" + mahoadon + "'";
            tong = Convert.ToDouble(Funtions.GetFileValues(sql));
            tongmoi = tong - thanhtien;
            sql = "update tblHDBan set tongtien = '" + tongmoi + "' where maHDBan = '" + mahoadon + "'";
            Funtions.Runsql(sql);
            tongtien.Text = tongmoi.ToString();
            tienbangchu.Text = "Bang chu: " + Funtions.ChuyenSoSangChu(tongmoi.ToString());
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma;
            ma = dataGridView1.CurrentRow.Cells["mh"].Value.ToString();
            DelHang(mahoadon.Text, ma);
            string thanhtien;
            thanhtien = dataGridView1.CurrentRow.Cells["tt"].Value.ToString();
            DelUpdateTongTien(mahoadon.Text, Convert.ToDouble(thanhtien));
            Load_DataGridView();
        }
    }
}
