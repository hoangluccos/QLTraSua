using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLTraSua
{
    public partial class FormThongTinBill : Form
    {
        DBDatMon dbdatmon;
        DataTable dtdatmon = null;
        DataView dtvdatmon = null;

        DBDoanhThu dbdoanhthu;
        DBHoaDonBanHang dbhoadonbanhang;

        DBBan dbban;

        string x = FormInBill.LuuMaBan.MaBan;
        public FormThongTinBill()
        {
            InitializeComponent();
            dbdatmon = new DBDatMon();
            dbhoadonbanhang = new DBHoaDonBanHang();
            dbdoanhthu = new DBDoanhThu();
            dbban = new DBBan();
        }
        void LoadData()
        {
            try
            {
                dtdatmon = new DataTable();
                dtdatmon.Clear();
                dtdatmon = dbdatmon.LayThongTinDatMon().Tables[0];
                dtvdatmon = new DataView(dtdatmon);
                
                dtvdatmon.RowFilter = "MaBan='" + x + "'";
                dgvDatMon.DataSource = dtvdatmon;

                //
                txtMaHD.Focus();
                datetime.Value = DateTime.Today;
                //

                int sodong = dgvDatMon.Rows.Count;
                int TongDoanhThu = 0;
                for (int i = 0; i < sodong - 1; i++)
                {
                    TongDoanhThu += Convert.ToInt32(dgvDatMon.Rows[i].Cells["ThanhTien"].Value.ToString());
                }

                txtTongTien.Text = TongDoanhThu.ToString();
                //MessageBox.Show(FormInBill.LuuMaBan.MaBan.ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void FormThongTinBill_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text;
            int stt = FormDoanhThu.LuuSTT.stt;
            int tongTien = int.Parse(txtTongTien.Text);
            DateTime x = DateTime.Today;
            string maNV = txtMaNV.Text;

            bool f = false;
            string err = "";
            // them vao hoadonbanhang
            try
            {
                f = dbhoadonbanhang.ThemHoaDonBanHang(ref err, MaHD, FormInBill.LuuMaBan.MaBan, tongTien, x, maNV);
                if (f)
                {
                    MessageBox.Show("Đã thêm  vào Hoa Don Ban Hang " + MaHD);
                }
                else
                {
                    MessageBox.Show("Chưa thêm xong!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //themdoanhthu
            
            try
            {
                f = dbdoanhthu.ThemDoanhThu(ref err, stt, MaHD, tongTien, x, maNV);
                if (f)
                {
                    MessageBox.Show("Đã thêm  vào Doanh Thu" + MaHD);
                }
                else
                {
                    MessageBox.Show("Chưa thêm xong!\n\r" + "Lỗi:" + err);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //xoa dat mon, tinh trang ban
            bool f1 = dbdatmon.XoaAllDatMon(ref err, FormInBill.LuuMaBan.MaBan);
            bool f2 = dbban.CapNhatTinhTrangBan(ref err, FormInBill.LuuMaBan.MaBan);

            
        }
    }

}
