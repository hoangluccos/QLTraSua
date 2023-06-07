namespace QLTraSua
{
    partial class FormNhapHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.labelVN = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhapHang);
            this.panel1.Location = new System.Drawing.Point(40, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 309);
            this.panel1.TabIndex = 0;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.TenNguyenLieu,
            this.DonGia});
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(856, 289);
            this.dgvNhapHang.TabIndex = 1;
            this.dgvNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellClick);
            this.dgvNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellContentClick_1);
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNguyenLieu";
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.MinimumWidth = 6;
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.Width = 150;
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.TenNguyenLieu.MinimumWidth = 6;
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(332, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Nguyên Liệu";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(763, 438);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 82);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.labelDonGia);
            this.panel2.Controls.Add(this.txtTenNL);
            this.panel2.Controls.Add(this.labelVN);
            this.panel2.Controls.Add(this.txtMaNL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(40, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 136);
            this.panel2.TabIndex = 3;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(323, 22);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 22);
            this.txtDonGia.TabIndex = 21;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonGia.Location = new System.Drawing.Point(249, 23);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(30, 17);
            this.labelDonGia.TabIndex = 20;
            this.labelDonGia.Text = "Giá";
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(84, 70);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(111, 22);
            this.txtTenNL.TabIndex = 19;
            // 
            // labelVN
            // 
            this.labelVN.AutoSize = true;
            this.labelVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVN.Location = new System.Drawing.Point(10, 71);
            this.labelVN.Name = "labelVN";
            this.labelVN.Size = new System.Drawing.Size(55, 17);
            this.labelVN.TabIndex = 18;
            this.labelVN.Text = "Tên NL";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(84, 22);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(111, 22);
            this.txtMaNL.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã NL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bảng Chi Tiết Nhập Hàng";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label labelVN;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}