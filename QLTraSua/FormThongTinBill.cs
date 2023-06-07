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
    public partial class FormThongTinBill : Form
    {
        DBDatMon dbdatmon;
        DataTable dtdatmon = null;
        DataView dtvdatmon = null;
        public FormThongTinBill()
        {
            InitializeComponent();
            dbdatmon = new DBDatMon();
        }
        void LoadData()
        {
            try
            {
                dtdatmon = new DataTable();
                dtdatmon.Clear();
                dtdatmon = dbdatmon.LayThongTinDatMon().Tables[0];
                dtvdatmon = new DataView(dtdatmon);
                string x = FormInBill.LuuMaBan.MaBan.ToString();
                dtvdatmon.RowFilter = "MaBan =  ' " + x + " ' ";
                dgvDatMon.DataSource = dtvdatmon;
                
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
    }

}
