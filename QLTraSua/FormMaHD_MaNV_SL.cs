using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLTraSua.FormSoLuongDat;

namespace QLTraSua
{
    public partial class FormMaHD_MaNV_SL : Form
    {
        public FormMaHD_MaNV_SL()
        {
            InitializeComponent();
        }

        private void FormMaHD_MaNV_SL_Load(object sender, EventArgs e)
        {
            txtMaHD.Focus();
        }
        public class LuuGiaTri
        {
            static public string MaHD;
            static public int SoLuong;
            static public string MaNV;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int a;
            // chuyển đổi txt -> int
            string b, c;
            b = txtMaHD.Text;
            c = txtMaNV.Text;
            bool result = int.TryParse(txtSoLuong.Text, out a);
            LuuGiaTri.MaHD = b;
            LuuGiaTri.MaNV = c;
            if (result)
            {
                //MessageBox.Show(a.ToString());
                LuuGiaTri.SoLuong = a;

                //MessageBox.Show(LuuSoLuong.SoLuong.ToString());
            }
            

            Close(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
