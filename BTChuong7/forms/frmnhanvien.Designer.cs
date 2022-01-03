
namespace BTChuong7
{
    partial class frmnhanvien
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
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.boqua = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gtinh = new System.Windows.Forms.GroupBox();
            this.nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.manhanvien = new System.Windows.Forms.TextBox();
            this.tennhanvien = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ns = new System.Windows.Forms.DateTimePicker();
            this.Gtinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(40, 396);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(143, 396);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(259, 396);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(384, 396);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 3;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // boqua
            // 
            this.boqua.Location = new System.Drawing.Point(525, 396);
            this.boqua.Name = "boqua";
            this.boqua.Size = new System.Drawing.Size(75, 23);
            this.boqua.TabIndex = 4;
            this.boqua.Text = "Bỏ qua";
            this.boqua.UseVisualStyleBackColor = true;
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(654, 396);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 5;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên nhân viên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 12;
            // 
            // Gtinh
            // 
            this.Gtinh.Controls.Add(this.nu);
            this.Gtinh.Controls.Add(this.nam);
            this.Gtinh.Location = new System.Drawing.Point(81, 189);
            this.Gtinh.Name = "Gtinh";
            this.Gtinh.Size = new System.Drawing.Size(281, 31);
            this.Gtinh.TabIndex = 13;
            this.Gtinh.TabStop = false;
            this.Gtinh.Text = "Giới tính:";
            this.Gtinh.TabIndexChanged += new System.EventHandler(this.groupBox1_TabIndexChanged);
            this.Gtinh.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nu
            // 
            this.nu.AutoSize = true;
            this.nu.Location = new System.Drawing.Point(166, 4);
            this.nu.Name = "nu";
            this.nu.Size = new System.Drawing.Size(47, 21);
            this.nu.TabIndex = 1;
            this.nu.TabStop = true;
            this.nu.Text = "Nữ";
            this.nu.UseVisualStyleBackColor = true;
            this.nu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Location = new System.Drawing.Point(93, 4);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(58, 21);
            this.nam.TabIndex = 0;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // manhanvien
            // 
            this.manhanvien.Location = new System.Drawing.Point(183, 106);
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Size = new System.Drawing.Size(179, 22);
            this.manhanvien.TabIndex = 14;
            // 
            // tennhanvien
            // 
            this.tennhanvien.Location = new System.Drawing.Point(183, 144);
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.Size = new System.Drawing.Size(179, 22);
            this.tennhanvien.TabIndex = 15;
            this.tennhanvien.TextChanged += new System.EventHandler(this.tennhanvien_TextChanged);
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(465, 105);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(171, 22);
            this.diachi.TabIndex = 16;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(465, 144);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(171, 22);
            this.sdt.TabIndex = 17;
            this.sdt.Text = "____ ____ ____";
            this.sdt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sdt_MouseDown);
            this.sdt.MouseLeave += new System.EventHandler(this.sdt_MouseLeave);
            this.sdt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sdt_MouseMove);
            this.sdt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sdt_MouseUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnv,
            this.tnv,
            this.gt,
            this.dc,
            this.dt,
            this.ngaysinh});
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // mnv
            // 
            this.mnv.DataPropertyName = "manhanvien";
            this.mnv.FillWeight = 23.74332F;
            this.mnv.HeaderText = "Mã nhân viên";
            this.mnv.MinimumWidth = 6;
            this.mnv.Name = "mnv";
            // 
            // tnv
            // 
            this.tnv.DataPropertyName = "tennhanvien";
            this.tnv.FillWeight = 23.74332F;
            this.tnv.HeaderText = "Tên nhân viên";
            this.tnv.MinimumWidth = 6;
            this.tnv.Name = "tnv";
            // 
            // gt
            // 
            this.gt.DataPropertyName = "gioitinh";
            this.gt.FillWeight = 23.74332F;
            this.gt.HeaderText = "Giới tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "diachi";
            this.dc.FillWeight = 23.74332F;
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            // 
            // dt
            // 
            this.dt.DataPropertyName = "dienthoai";
            this.dt.FillWeight = 23.74332F;
            this.dt.HeaderText = "Điện thoại";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.FillWeight = 481.2834F;
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            // 
            // ns
            // 
            this.ns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ns.Location = new System.Drawing.Point(472, 184);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(164, 22);
            this.ns.TabIndex = 20;
            this.ns.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 586);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.tennhanvien);
            this.Controls.Add(this.manhanvien);
            this.Controls.Add(this.Gtinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.boqua);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Name = "frmnhanvien";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            this.Gtinh.ResumeLayout(false);
            this.Gtinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button boqua;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Gtinh;
        private System.Windows.Forms.TextBox manhanvien;
        private System.Windows.Forms.TextBox tennhanvien;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.DateTimePicker ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
    }
}