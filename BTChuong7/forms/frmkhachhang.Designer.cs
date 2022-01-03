
namespace BTChuong7
{
    partial class frmkhachhang
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
            this.makhach = new System.Windows.Forms.TextBox();
            this.tenkhach = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.dienthoai = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(48, 390);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 0;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(154, 389);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 1;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(276, 389);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 2;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(403, 389);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 3;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // boqua
            // 
            this.boqua.Location = new System.Drawing.Point(552, 389);
            this.boqua.Name = "boqua";
            this.boqua.Size = new System.Drawing.Size(75, 23);
            this.boqua.TabIndex = 4;
            this.boqua.Text = "Bỏ qua";
            this.boqua.UseVisualStyleBackColor = true;
            this.boqua.Click += new System.EventHandler(this.boqua_Click);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(697, 388);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 5;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Điện thoại";
            // 
            // makhach
            // 
            this.makhach.Location = new System.Drawing.Point(185, 84);
            this.makhach.Name = "makhach";
            this.makhach.Size = new System.Drawing.Size(154, 22);
            this.makhach.TabIndex = 11;
            // 
            // tenkhach
            // 
            this.tenkhach.Location = new System.Drawing.Point(185, 123);
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.Size = new System.Drawing.Size(154, 22);
            this.tenkhach.TabIndex = 12;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(480, 83);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(178, 22);
            this.diachi.TabIndex = 13;
            // 
            // dienthoai
            // 
            this.dienthoai.Location = new System.Drawing.Point(480, 122);
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Size = new System.Drawing.Size(178, 22);
            this.dienthoai.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mk,
            this.tk,
            this.dc,
            this.dt});
            this.dataGridView1.Location = new System.Drawing.Point(45, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.Move += new System.EventHandler(this.dataGridView1_Move);
            // 
            // mk
            // 
            this.mk.DataPropertyName = "makhach";
            this.mk.HeaderText = "Mã khách";
            this.mk.MinimumWidth = 6;
            this.mk.Name = "mk";
            // 
            // tk
            // 
            this.tk.DataPropertyName = "tenkhach";
            this.tk.HeaderText = "Tên khách ";
            this.tk.MinimumWidth = 6;
            this.tk.Name = "tk";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "diachi";
            this.dc.HeaderText = "Địa chỉ";
            this.dc.MinimumWidth = 6;
            this.dc.Name = "dc";
            // 
            // dt
            // 
            this.dt.DataPropertyName = "dienthoai";
            this.dt.HeaderText = "Điện thoại";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dienthoai);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.tenkhach);
            this.Controls.Add(this.makhach);
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
            this.Name = "frmkhachhang";
            this.Text = "frmkhachhang";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            this.Click += new System.EventHandler(this.frmkhachhang_Click);
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
        private System.Windows.Forms.TextBox makhach;
        private System.Windows.Forms.TextBox tenkhach;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox dienthoai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
    }
}