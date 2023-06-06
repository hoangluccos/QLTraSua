using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua
{
    public partial class FormSoLuongDat : Form
    {
        public FormSoLuongDat()
        {
            InitializeComponent();
        }
        public class LuuSoLuong
        {
            static public int SoLuong;
        }
        private void FormSoLuongDat_Load(object sender, EventArgs e)
        {
            txtSoLuong.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int a;
            bool result = int.TryParse(txtSoLuong.Text, out a);
            if (result)
            {
                //MessageBox.Show(a.ToString());
                LuuSoLuong.SoLuong = a;
                //MessageBox.Show(LuuSoLuong.SoLuong.ToString());
            }
            Close();
        }
    }
}
