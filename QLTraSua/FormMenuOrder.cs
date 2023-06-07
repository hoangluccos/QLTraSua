using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BALayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTraSua
{
    public partial class FormMenuOrder : Form
    {
        DBMenu dbmenu;
        DataTable dtmenu = null;

        DBDatMon dbdatmon;
        DataTable dtdatmon = null;
        DataView dtvdatmon = null;

        string MaBan = FormBancs.LuuMaBan.MaBan;
        public FormMenuOrder()
        {
            InitializeComponent();
            dbmenu = new DBMenu();
            dbdatmon = new DBDatMon();
        }
        void LoadData1() //ts
        {
            try
            {
                dtmenu = new DataTable();
                dtmenu.Clear();
                dtmenu = dbmenu.LayThongTinMenuTS().Tables[0];

                dgvmenu.DataSource = dtmenu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void LoadData2() //yk
        {
            try
            {
                dtmenu = new DataTable();
                dtmenu.Clear();
                dtmenu = dbmenu.LayThongTinMenuYK().Tables[0];

                dgvmenu.DataSource = dtmenu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void LoadData3() //toping
        {
            try
            {
                dtmenu = new DataTable();
                dtmenu.Clear();
                dtmenu = dbmenu.LayThongTinMenuToping().Tables[0];

                dgvmenu.DataSource = dtmenu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void LoadData4() //khac
        {
            try
            {
                dtmenu = new DataTable();
                dtmenu.Clear();
                dtmenu = dbmenu.LayThongTinMenuTT().Tables[0];

                dgvmenu.DataSource = dtmenu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void LoadData5()
        {
            try
            {
                dtdatmon = new DataTable();
                dtdatmon.Clear();
                dtdatmon = dbdatmon.LayThongTinDatMon().Tables[0];

                dgvDatMon.DataSource = dtdatmon;                           
                dtvdatmon = new DataView(dtdatmon);

                dtvdatmon.RowFilter = "MaBan='" + MaBan + "'";
                dgvDatMon.DataSource = dtvdatmon;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnExit_Click(object sender,   EventArgs e)
        {
            string err = "";
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không", "Câu Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                bool f = dbdatmon.XoaAllDatMon(ref err, MaBan);
                if(f)
                    Close();
            }    
            else
            {
                MessageBox.Show("Không thoát khỏi Đặt Hàng");
            }
        }

        private void btnTraSua_Click(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void btnYK_Click(object sender, EventArgs e)
        {
            LoadData2();

        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            LoadData3();

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            LoadData4();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form x = new FormSoLuongDat();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();

            
            //MessageBox.Show(FormSoLuongDat.LuuSoLuong.SoLuong.ToString());
            int r = dgvmenu.CurrentCell.RowIndex;

            string MaMon = dgvmenu.Rows[r].Cells[0].Value.ToString();
            int DonGia = Convert.ToInt32(dgvmenu.Rows[r].Cells[2].Value.ToString());
            int thanhTien = FormSoLuongDat.LuuSoLuong.SoLuong * DonGia;
            bool f = false;
            string err = "";
            try
            {
                f = dbdatmon.ThemDatMon(ref err, FormBancs.LuuMaBan.MaBan, MaMon, FormSoLuongDat.LuuSoLuong.SoLuong, DonGia , thanhTien);
                if (f)
                {
                    MessageBox.Show("Đã thêm 1 Món vào " + MaBan);
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

            LoadData5();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi Món thành công");
            Close();
        }
    }
}