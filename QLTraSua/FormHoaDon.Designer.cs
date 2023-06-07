namespace QLTraSua
{
    partial class FormHoaDon
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
            this.dgvHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.MaHoaDonBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDonBanHang
            // 
            this.dgvHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDonBanHang,
            this.MaBan,
            this.TongTien,
            this.NgayXuatHoaDon,
            this.MaNhanVien});
            this.dgvHoaDonBanHang.Location = new System.Drawing.Point(35, 81);
            this.dgvHoaDonBanHang.Name = "dgvHoaDonBanHang";
            this.dgvHoaDonBanHang.RowHeadersWidth = 51;
            this.dgvHoaDonBanHang.RowTemplate.Height = 24;
            this.dgvHoaDonBanHang.Size = new System.Drawing.Size(844, 430);
            this.dgvHoaDonBanHang.TabIndex = 0;
            // 
            // MaHoaDonBanHang
            // 
            this.MaHoaDonBanHang.DataPropertyName = "MaHoaDonBanHang";
            this.MaHoaDonBanHang.HeaderText = "Mã Hóa Đơn Bán Hàng";
            this.MaHoaDonBanHang.MinimumWidth = 6;
            this.MaHoaDonBanHang.Name = "MaHoaDonBanHang";
            this.MaHoaDonBanHang.Width = 175;
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MaBan";
            this.MaBan.HeaderText = "Mã Bàn";
            this.MaBan.MinimumWidth = 6;
            this.MaBan.Name = "MaBan";
            this.MaBan.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // NgayXuatHoaDon
            // 
            this.NgayXuatHoaDon.DataPropertyName = "NgayXuatHoaDon";
            this.NgayXuatHoaDon.HeaderText = "Ngày Xuất Hóa Đơn";
            this.NgayXuatHoaDon.MinimumWidth = 6;
            this.NgayXuatHoaDon.Name = "NgayXuatHoaDon";
            this.NgayXuatHoaDon.Width = 175;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN BÁN HÀNG";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightCoral;
            this.button13.Location = new System.Drawing.Point(824, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 40);
            this.button13.TabIndex = 15;
            this.button13.Text = "Exit";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 564);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDonBanHang);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDonBanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDonBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.Button button13;
    }
}