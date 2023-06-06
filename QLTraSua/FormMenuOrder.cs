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
    public partial class FormMenuOrder : Form
    {
        DBMenu dbmenu;
        DataTable dtmenu = null;
        public FormMenuOrder()
        {
            InitializeComponent();
            dbmenu = new DBMenu();
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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}