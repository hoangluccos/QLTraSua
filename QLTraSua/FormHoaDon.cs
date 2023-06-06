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

namespace QLTraSua
{
    public partial class FormHoaDon : Form
    {
        DBHoaDonBanHang dbhoadonbanhang;
        DataTable dthoadonbanhang = null;
        public FormHoaDon()
        {
            InitializeComponent();
            dbhoadonbanhang = new DBHoaDonBanHang();
        }

        void LoadData()
        {
            try
            {
                dthoadonbanhang = new DataTable();
                dthoadonbanhang.Clear();
                dthoadonbanhang = dbhoadonbanhang.LayThongTinHoaDonBanHang().Tables[0];

                dgvHoaDonBanHang.DataSource = dthoadonbanhang;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
