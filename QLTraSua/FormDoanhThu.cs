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
        DataView dtvdoanhthu = null;
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

                dtvdoanhthu = new DataView(dtdoanhthu);

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

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpDau.Value.Date > dtpCuoi.Value.Date)
            {
                MessageBox.Show("Ngày Bắt đầu không thể lớn hơn ngày Kết Thúc");
            }    
            else
            {
                dtvdoanhthu.RowFilter = "(NgayNhapDoanhThu>'" + dtpDau.Value.Date + "' and NgayNhapDoanhThu<'" + dtpCuoi.Value.Date + "')" +
                    "or NgayNhapDoanhThu='" + dtpDau.Value.Date + "'or NgayNhapDoanhThu='" + dtpCuoi.Value.Date +"'";
                dgvDoanhThu.DataSource = dtvdoanhthu;
                int sodong = dgvDoanhThu.Rows.Count;
                int TongDoanhThu = 0;
                for (int i=0; i<sodong-1; i++)
                {
                    TongDoanhThu += Convert.ToInt32(dgvDoanhThu.Rows[i].Cells["TongTien"].Value.ToString());
                }    
                txtTongDoanhThu.Text = TongDoanhThu.ToString();
            }    
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            dtvdoanhthu.RowFilter = "";
            dgvDoanhThu.DataSource = dtvdoanhthu;
            int TongDoanhThu = Convert.ToInt32(dtdoanhthu.Compute("SUM(TongTien)", string.Empty));
            txtTongDoanhThu.Text = TongDoanhThu.ToString();
        }
    }
}
