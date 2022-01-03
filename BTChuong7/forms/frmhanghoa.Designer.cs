
namespace BTChuong7
{
    partial class frmhanghoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mahang = new System.Windows.Forms.TextBox();
            this.tenhang = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.gianhap = new System.Windows.Forms.TextBox();
            this.giaban = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ghichu = new System.Windows.Forms.TextBox();
            this.anh = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.macl = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.boqua = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.Button();
            this.hienthi = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục hàng hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(53, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã chất liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ảnh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ghi chú";
            // 
            // mahang
            // 
            this.mahang.Location = new System.Drawing.Point(154, 103);
            this.mahang.Name = "mahang";
            this.mahang.Size = new System.Drawing.Size(180, 22);
            this.mahang.TabIndex = 9;
            this.mahang.DoubleClick += new System.EventHandler(this.mahang_DoubleClick);
            // 
            // tenhang
            // 
            this.tenhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tenhang.Location = new System.Drawing.Point(154, 149);
            this.tenhang.Name = "tenhang";
            this.tenhang.Size = new System.Drawing.Size(180, 22);
            this.tenhang.TabIndex = 10;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(154, 241);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(180, 22);
            this.soluong.TabIndex = 12;
            // 
            // gianhap
            // 
            this.gianhap.Location = new System.Drawing.Point(154, 292);
            this.gianhap.Name = "gianhap";
            this.gianhap.Size = new System.Drawing.Size(180, 22);
            this.gianhap.TabIndex = 13;
            // 
            // giaban
            // 
            this.giaban.Location = new System.Drawing.Point(154, 331);
            this.giaban.Name = "giaban";
            this.giaban.Size = new System.Drawing.Size(180, 22);
            this.giaban.TabIndex = 14;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(505, 100);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(100, 22);
            this.file.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(519, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Open file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ghichu
            // 
            this.ghichu.Location = new System.Drawing.Point(505, 232);
            this.ghichu.Multiline = true;
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(266, 104);
            this.ghichu.TabIndex = 17;
            // 
            // anh
            // 
            this.anh.Location = new System.Drawing.Point(648, 100);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(126, 114);
            this.anh.TabIndex = 18;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // macl
            // 
            this.macl.FormattingEnabled = true;
            this.macl.Location = new System.Drawing.Point(154, 194);
            this.macl.Name = "macl";
            this.macl.Size = new System.Drawing.Size(180, 24);
            this.macl.TabIndex = 19;
            this.macl.SelectedIndexChanged += new System.EventHandler(this.macl_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mh,
            this.th,
            this.machatlieu,
            this.soluong1,
            this.dongianhap,
            this.dongiaban});
            this.dataGridView1.Location = new System.Drawing.Point(40, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // machatlieu
            // 
            this.machatlieu.DataPropertyName = "machatlieu";
            this.machatlieu.HeaderText = "Mã chất liệu";
            this.machatlieu.MinimumWidth = 6;
            this.machatlieu.Name = "machatlieu";
            this.machatlieu.Width = 125;
            // 
            // soluong1
            // 
            this.soluong1.DataPropertyName = "soluong";
            this.soluong1.HeaderText = "Số lượng";
            this.soluong1.MinimumWidth = 6;
            this.soluong1.Name = "soluong1";
            this.soluong1.Width = 125;
            // 
            // dongianhap
            // 
            this.dongianhap.DataPropertyName = "dongianhap";
            this.dongianhap.HeaderText = "Đơn giá nhập";
            this.dongianhap.MinimumWidth = 6;
            this.dongianhap.Name = "dongianhap";
            this.dongianhap.Width = 125;
            // 
            // dongiaban
            // 
            this.dongiaban.DataPropertyName = "dongiaban";
            this.dongiaban.HeaderText = "Đơn giá bán";
            this.dongiaban.MinimumWidth = 6;
            this.dongiaban.Name = "dongiaban";
            this.dongiaban.Width = 125;
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.them.Cursor = System.Windows.Forms.Cursors.No;
            this.them.Location = new System.Drawing.Point(40, 532);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 21;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(121, 532);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 22;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(206, 532);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 23;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(287, 532);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 24;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // boqua
            // 
            this.boqua.Location = new System.Drawing.Point(378, 532);
            this.boqua.Name = "boqua";
            this.boqua.Size = new System.Drawing.Size(75, 23);
            this.boqua.TabIndex = 25;
            this.boqua.Text = "Bỏ qua";
            this.boqua.UseVisualStyleBackColor = true;
            this.boqua.Click += new System.EventHandler(this.boqua_Click);
            // 
            // tk
            // 
            this.tk.Location = new System.Drawing.Point(473, 532);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(75, 23);
            this.tk.TabIndex = 26;
            this.tk.Text = "Tìm kiếm";
            this.tk.UseVisualStyleBackColor = true;
            this.tk.Click += new System.EventHandler(this.tk_Click);
            // 
            // hienthi
            // 
            this.hienthi.Location = new System.Drawing.Point(561, 532);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(85, 23);
            this.hienthi.TabIndex = 27;
            this.hienthi.Text = "Hiển thị Ds";
            this.hienthi.UseVisualStyleBackColor = true;
            this.hienthi.Click += new System.EventHandler(this.hienthi_Click);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(673, 532);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 28;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            // 
            // frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.boqua);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.macl);
            this.Controls.Add(this.anh);
            this.Controls.Add(this.ghichu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file);
            this.Controls.Add(this.giaban);
            this.Controls.Add(this.gianhap);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.tenhang);
            this.Controls.Add(this.mahang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmhanghoa";
            this.Text = "frmhanghoa";
            this.Load += new System.EventHandler(this.frmhanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mahang;
        private System.Windows.Forms.TextBox tenhang;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.TextBox gianhap;
        private System.Windows.Forms.TextBox giaban;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ghichu;
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox macl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button boqua;
        private System.Windows.Forms.Button tk;
        private System.Windows.Forms.Button hienthi;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn th;
        private System.Windows.Forms.DataGridViewTextBoxColumn machatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaban;
    }
}