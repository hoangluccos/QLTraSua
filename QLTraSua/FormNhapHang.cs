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
    public partial class FormNhapHang : Form
    {
        DBNguyenLieu dbnguyenlieu;
        DataTable dtnguyenlieu = null;
        DBHoaDonNhapHang dbhoadonnhaphang;
        DataTable dthoadonnhaphang;
        public FormNhapHang()
        {
            InitializeComponent();
            dbnguyenlieu=new DBNguyenLieu();
        }
        void LoadData()
        {
            try
            {
                dtnguyenlieu = new DataTable();
                dtnguyenlieu.Clear();
                dtnguyenlieu = dbnguyenlieu.LayThongTinNguyenLieu().Tables[0];

                dgvNhapHang.DataSource = dtnguyenlieu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhapHang.CurrentCell.RowIndex;
            txtMaNL.Text = dgvNhapHang.Rows[r].Cells[1].Value.ToString();
            txtTenNL.Text = dgvNhapHang.Rows[r].Cells[1].Value.ToString();
            txtDonGia.Text = dgvNhapHang.Rows[r].Cells[1].Value.ToString();

        }
    }
}
