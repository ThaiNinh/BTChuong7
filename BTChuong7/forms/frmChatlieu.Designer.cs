
namespace BTChuong7
{
    partial class frmChatlieu
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
            this.machatlieu = new System.Windows.Forms.TextBox();
            this.tenchatlieu = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.boqua = new System.Windows.Forms.Button();
            this.dong = new System.Windows.Forms.Button();
            this.tencl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(311, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã chất liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên chất liệu";
            // 
            // machatlieu
            // 
            this.machatlieu.Location = new System.Drawing.Point(443, 148);
            this.machatlieu.Name = "machatlieu";
            this.machatlieu.Size = new System.Drawing.Size(239, 22);
            this.machatlieu.TabIndex = 3;
            // 
            // tenchatlieu
            // 
            this.tenchatlieu.Location = new System.Drawing.Point(443, 196);
            this.tenchatlieu.Name = "tenchatlieu";
            this.tenchatlieu.Size = new System.Drawing.Size(239, 22);
            this.tenchatlieu.TabIndex = 4;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(265, 432);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 6;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(346, 432);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 7;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(427, 432);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 8;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(508, 432);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 23);
            this.luu.TabIndex = 9;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // boqua
            // 
            this.boqua.Location = new System.Drawing.Point(590, 432);
            this.boqua.Name = "boqua";
            this.boqua.Size = new System.Drawing.Size(75, 23);
            this.boqua.TabIndex = 10;
            this.boqua.Text = "Bỏ qua";
            this.boqua.UseVisualStyleBackColor = true;
            this.boqua.Click += new System.EventHandler(this.boqua_Click);
            // 
            // dong
            // 
            this.dong.Location = new System.Drawing.Point(672, 432);
            this.dong.Name = "dong";
            this.dong.Size = new System.Drawing.Size(75, 23);
            this.dong.TabIndex = 11;
            this.dong.Text = "Đóng";
            this.dong.UseVisualStyleBackColor = true;
            this.dong.Click += new System.EventHandler(this.dong_Click);
            // 
            // tencl
            // 
            this.tencl.DataPropertyName = "tenchatlieu";
            this.tencl.HeaderText = "Tên chất liệu";
            this.tencl.MinimumWidth = 6;
            this.tencl.Name = "tencl";
            this.tencl.Width = 500;
            // 
            // macl
            // 
            this.macl.DataPropertyName = "machatlieu";
            this.macl.HeaderText = "Mã chất liệu";
            this.macl.MinimumWidth = 6;
            this.macl.Name = "macl";
            this.macl.Width = 170;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macl,
            this.tencl});
            this.DataGridView.Location = new System.Drawing.Point(245, 248);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(656, 166);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // frmChatlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 597);
            this.Controls.Add(this.dong);
            this.Controls.Add(this.boqua);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.tenchatlieu);
            this.Controls.Add(this.machatlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChatlieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChatlieu";
            this.Load += new System.EventHandler(this.frmChatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox machatlieu;
        private System.Windows.Forms.TextBox tenchatlieu;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button boqua;
        private System.Windows.Forms.Button dong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencl;
        private System.Windows.Forms.DataGridViewTextBoxColumn macl;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}