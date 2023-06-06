namespace QLTraSua
{
    partial class FormMenuOrder
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
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnTP = new System.Windows.Forms.Button();
            this.btnYK = new System.Windows.Forms.Button();
            this.btnTraSua = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvmenu = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatMon = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.MaMon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatMon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Location = new System.Drawing.Point(701, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 47);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(184)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnOther);
            this.panel1.Controls.Add(this.btnTP);
            this.panel1.Controls.Add(this.btnYK);
            this.panel1.Controls.Add(this.btnTraSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 530);
            this.panel1.TabIndex = 1;
            // 
            // btnOther
            // 
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOther.Location = new System.Drawing.Point(0, 171);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(189, 57);
            this.btnOther.TabIndex = 4;
            this.btnOther.Text = "Khác";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnTP
            // 
            this.btnTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTP.Location = new System.Drawing.Point(0, 114);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(189, 57);
            this.btnTP.TabIndex = 2;
            this.btnTP.Text = "Toping";
            this.btnTP.UseVisualStyleBackColor = true;
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // btnYK
            // 
            this.btnYK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYK.Location = new System.Drawing.Point(0, 57);
            this.btnYK.Name = "btnYK";
            this.btnYK.Size = new System.Drawing.Size(189, 57);
            this.btnYK.TabIndex = 1;
            this.btnYK.Text = "Yakulk";
            this.btnYK.UseVisualStyleBackColor = true;
            this.btnYK.Click += new System.EventHandler(this.btnYK_Click);
            // 
            // btnTraSua
            // 
            this.btnTraSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraSua.Location = new System.Drawing.Point(0, 0);
            this.btnTraSua.Name = "btnTraSua";
            this.btnTraSua.Size = new System.Drawing.Size(189, 57);
            this.btnTraSua.TabIndex = 0;
            this.btnTraSua.Text = "Trà Sữa";
            this.btnTraSua.UseVisualStyleBackColor = true;
            this.btnTraSua.Click += new System.EventHandler(this.btnTraSua_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHoanThanh.Location = new System.Drawing.Point(694, 395);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(196, 48);
            this.btnHoanThanh.TabIndex = 3;
            this.btnHoanThanh.Text = "Hoàn Thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnHoanThanh);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(189, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 530);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDatMon);
            this.panel4.Location = new System.Drawing.Point(6, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 185);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvmenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 339);
            this.panel3.TabIndex = 0;
            // 
            // dgvmenu
            // 
            this.dgvmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.DonGia});
            this.dgvmenu.Location = new System.Drawing.Point(6, 0);
            this.dgvmenu.Name = "dgvmenu";
            this.dgvmenu.RowHeadersWidth = 51;
            this.dgvmenu.RowTemplate.Height = 24;
            this.dgvmenu.Size = new System.Drawing.Size(949, 294);
            this.dgvmenu.TabIndex = 0;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Món";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 280;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 280;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 275;
            // 
            // dgvDatMon
            // 
            this.dgvDatMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon1,
            this.SoLuong,
            this.DonGia1,
            this.ThanhTien});
            this.dgvDatMon.Location = new System.Drawing.Point(4, 4);
            this.dgvDatMon.Name = "dgvDatMon";
            this.dgvDatMon.RowHeadersWidth = 51;
            this.dgvDatMon.RowTemplate.Height = 24;
            this.dgvDatMon.Size = new System.Drawing.Size(615, 172);
            this.dgvDatMon.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(694, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 48);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MaMon1
            // 
            this.MaMon1.DataPropertyName = "MaMon";
            this.MaMon1.HeaderText = "Mã Món";
            this.MaMon1.MinimumWidth = 6;
            this.MaMon1.Name = "MaMon1";
            this.MaMon1.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DonGia";
            this.DonGia1.HeaderText = "Đơn Giá";
            this.DonGia1.MinimumWidth = 6;
            this.DonGia1.Name = "DonGia1";
            this.DonGia1.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // FormMenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuOrder";
            this.Text = "FormMenuOrder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.Button btnYK;
        private System.Windows.Forms.Button btnTraSua;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvmenu;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDatMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}