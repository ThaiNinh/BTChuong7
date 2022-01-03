
namespace BTChuong7
{
    partial class frmHDBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.makhachhang = new System.Windows.Forms.ComboBox();
            this.manhanvien = new System.Windows.Forms.ComboBox();
            this.dienthoai = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.tenkhach = new System.Windows.Forms.TextBox();
            this.tennhanvien = new System.Windows.Forms.TextBox();
            this.ngayban = new System.Windows.Forms.DateTimePicker();
            this.mahoadon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mahang = new System.Windows.Forms.ComboBox();
            this.dong = new System.Windows.Forms.Button();
            this.IN = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.thanhtien = new System.Windows.Forms.TextBox();
            this.dongia = new System.Windows.Forms.TextBox();
            this.giamgia = new System.Windows.Forms.TextBox();
            this.tenhang = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tienbangchu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbotim = new System.Windows.Forms.ComboBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.makhachhang);
            this.groupBox1.Controls.Add(this.manhanvien);
            this.groupBox1.Controls.Add(this.dienthoai);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.tenkhach);
            this.groupBox1.Controls.Add(this.tennhanvien);
            this.groupBox1.Controls.Add(this.ngayban);
            this.groupBox1.Controls.Add(this.mahoadon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin chung";
            // 
            // makhachhang
            // 
            this.makhachhang.FormattingEnabled = true;
            this.makhachhang.Location = new System.Drawing.Point(524, 32);
            this.makhachhang.Name = "makhachhang";
            this.makhachhang.Size = new System.Drawing.Size(197, 24);
            this.makhachhang.TabIndex = 17;
            this.makhachhang.SelectedIndexChanged += new System.EventHandler(this.makhachhang_SelectedIndexChanged);
            this.makhachhang.TextChanged += new System.EventHandler(this.makhachhang_TextChanged);
            // 
            // manhanvien
            // 
            this.manhanvien.FormattingEnabled = true;
            this.manhanvien.Location = new System.Drawing.Point(139, 108);
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Size = new System.Drawing.Size(204, 24);
            this.manhanvien.TabIndex = 16;
            this.manhanvien.SelectedValueChanged += new System.EventHandler(this.manhanvien_SelectedValueChanged);
            this.manhanvien.TextChanged += new System.EventHandler(this.manhanvien_TextChanged);
            this.manhanvien.Click += new System.EventHandler(this.manhanvien_Click);
            // 
            // dienthoai
            // 
            this.dienthoai.Location = new System.Drawing.Point(524, 151);
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Size = new System.Drawing.Size(197, 22);
            this.dienthoai.TabIndex = 15;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(524, 110);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(197, 22);
            this.diachi.TabIndex = 14;
            // 
            // tenkhach
            // 
            this.tenkhach.Location = new System.Drawing.Point(524, 73);
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.Size = new System.Drawing.Size(197, 22);
            this.tenkhach.TabIndex = 13;
            // 
            // tennhanvien
            // 
            this.tennhanvien.Location = new System.Drawing.Point(139, 145);
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.Size = new System.Drawing.Size(204, 22);
            this.tennhanvien.TabIndex = 11;
            // 
            // ngayban
            // 
            this.ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayban.Location = new System.Drawing.Point(139, 76);
            this.ngayban.Name = "ngayban";
            this.ngayban.Size = new System.Drawing.Size(204, 22);
            this.ngayban.TabIndex = 9;
            // 
            // mahoadon
            // 
            this.mahoadon.Location = new System.Drawing.Point(139, 39);
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Size = new System.Drawing.Size(204, 22);
            this.mahoadon.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mahang);
            this.groupBox2.Controls.Add(this.dong);
            this.groupBox2.Controls.Add(this.IN);
            this.groupBox2.Controls.Add(this.huy);
            this.groupBox2.Controls.Add(this.luu);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.tongtien);
            this.groupBox2.Controls.Add(this.thanhtien);
            this.groupBox2.Controls.Add(this.dongia);
            this.groupBox2.Controls.Add(this.giamgia);
            this.groupBox2.Controls.Add(this.tenhang);
            this.groupBox2.Controls.Add(this.soluong);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tienbangchu);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(27, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 392);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // mahang
            // 
            this.mahang.FormattingEnabled = true;
            this.mahang.Location = new System.Drawing.Point(97, 22);
            this.mahang.Name = "mahang";
            this.mahang.Size = new System.Drawing.Size(140, 24);
            this.mahang.TabIndex = 22;
            this.mahang.TextChanged += new System.EventHandler(this.mahang_TextChanged);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(650, 353);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 33);
            this.dong.TabIndex = 21;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // IN
            // 
            this.IN.Location = new System.Drawing.Point(472, 353);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(97, 33);
            this.IN.TabIndex = 20;
            this.IN.Text = "In hóa đơn";
            this.IN.UseVisualStyleBackColor = true;
            this.IN.Click += new System.EventHandler(this.IN_Click);
            // 
            // huy
            // 
            this.huy.Location = new System.Drawing.Point(322, 353);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(107, 33);
            this.huy.TabIndex = 19;
            this.huy.Text = "Hủy hóa đơn";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(195, 353);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 33);
            this.luu.TabIndex = 18;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(43, 353);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(113, 33);
            this.them.TabIndex = 17;
            this.them.Text = "Thêm hóa đơn";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(560, 301);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(189, 22);
            this.tongtien.TabIndex = 16;
            this.tongtien.TextChanged += new System.EventHandler(this.tongtien_TextChanged);
            // 
            // thanhtien
            // 
            this.thanhtien.Location = new System.Drawing.Point(587, 54);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(203, 22);
            this.thanhtien.TabIndex = 15;
            // 
            // dongia
            // 
            this.dongia.Location = new System.Drawing.Point(587, 25);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(203, 22);
            this.dongia.TabIndex = 14;
            // 
            // giamgia
            // 
            this.giamgia.Location = new System.Drawing.Point(333, 52);
            this.giamgia.Name = "giamgia";
            this.giamgia.Size = new System.Drawing.Size(151, 22);
            this.giamgia.TabIndex = 13;
            this.giamgia.TextChanged += new System.EventHandler(this.giamgia_TextChanged);
            // 
            // tenhang
            // 
            this.tenhang.Location = new System.Drawing.Point(333, 27);
            this.tenhang.Name = "tenhang";
            this.tenhang.Size = new System.Drawing.Size(151, 22);
            this.tenhang.TabIndex = 12;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(96, 52);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(141, 22);
            this.soluong.TabIndex = 11;
            this.soluong.TextChanged += new System.EventHandler(this.soluong_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(469, 306);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "Tổng tiền";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(24, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Kích đúp một hàng để xóa";
            // 
            // tienbangchu
            // 
            this.tienbangchu.AutoSize = true;
            this.tienbangchu.Location = new System.Drawing.Point(40, 333);
            this.tienbangchu.Name = "tienbangchu";
            this.tienbangchu.Size = new System.Drawing.Size(99, 17);
            this.tienbangchu.TabIndex = 7;
            this.tienbangchu.Text = "Tiền bằng chữ";
            this.tienbangchu.TextChanged += new System.EventHandler(this.tienbangchu_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mh,
            this.th,
            this.sl,
            this.dg,
            this.gg,
            this.tt});
            this.dataGridView1.Location = new System.Drawing.Point(33, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 201);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mh
            // 
            this.mh.DataPropertyName = "mahang";
            this.mh.HeaderText = "Mã hàng";
            this.mh.MinimumWidth = 6;
            this.mh.Name = "mh";
            this.mh.Width = 125;
            // 
            // th
            // 
            this.th.DataPropertyName = "tenhang";
            this.th.HeaderText = "Tên hàng";
            this.th.MinimumWidth = 6;
            this.th.Name = "th";
            this.th.Width = 125;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "soluong";
            this.sl.HeaderText = "Số lượng";
            this.sl.MinimumWidth = 6;
            this.sl.Name = "sl";
            this.sl.Width = 125;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "dongia";
            this.dg.HeaderText = "Đơn giá";
            this.dg.MinimumWidth = 6;
            this.dg.Name = "dg";
            this.dg.Width = 125;
            // 
            // gg
            // 
            this.gg.DataPropertyName = "giamgia";
            this.gg.HeaderText = "Giảm giá %";
            this.gg.MinimumWidth = 6;
            this.gg.Name = "gg";
            this.gg.Width = 125;
            // 
            // tt
            // 
            this.tt.DataPropertyName = "thanhtien";
            this.tt.HeaderText = "Thành tiền";
            this.tt.MinimumWidth = 6;
            this.tt.Name = "tt";
            this.tt.Width = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(493, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(490, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Đơn giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Giảm giá %";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã hàng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 677);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Mã hóa đơn";
            // 
            // cbotim
            // 
            this.cbotim.FormattingEnabled = true;
            this.cbotim.Location = new System.Drawing.Point(151, 677);
            this.cbotim.Name = "cbotim";
            this.cbotim.Size = new System.Drawing.Size(192, 24);
            this.cbotim.TabIndex = 4;
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(349, 674);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 29);
            this.timkiem.TabIndex = 5;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // frmHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 706);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.cbotim);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmHDBan";
            this.Text = "frmHDNhap";
            this.Load += new System.EventHandler(this.frmHDNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label tienbangchu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbotim;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.DateTimePicker ngayban;
        private System.Windows.Forms.TextBox mahoadon;
        private System.Windows.Forms.TextBox tennhanvien;
        private System.Windows.Forms.TextBox dienthoai;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox tenkhach;
        private System.Windows.Forms.TextBox thanhtien;
        private System.Windows.Forms.TextBox dongia;
        private System.Windows.Forms.TextBox giamgia;
        private System.Windows.Forms.TextBox tenhang;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Button IN;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn th;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.ComboBox makhachhang;
        private System.Windows.Forms.ComboBox manhanvien;
        private System.Windows.Forms.ComboBox mahang;
    }
}