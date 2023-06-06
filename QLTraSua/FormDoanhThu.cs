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
using System.Windows.Forms;

namespace QLTraSua
{
    public partial class FormDoanhThu : Form
    {
        DBDoanhThu dbdoanhthu;
        DataTable dtdoanhthu = null;
        public FormDoanhThu()
        {
            InitializeComponent();
            dbdoanhthu = new DBDoanhThu();
        }
        void LoadData()
        {
            try
            {
                dtdoanhthu = new DataTable();
                dtdoanhthu.Clear();
                dtdoanhthu = dbdoanhthu.LayThongTinDoanhThu().Tables[0];

                dgvDoanhThu.DataSource = dtdoanhthu;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            LoadData();
            panel1.Enabled = false;
        }
    }
}
