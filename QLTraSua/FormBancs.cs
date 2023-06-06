using BALayer;
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
    public partial class FormBancs : Form
    {
        DBBan dbban;

        public FormBancs()
        {
            InitializeComponent();
            dbban = new DBBan();
        }
        public class LuuMaBan
        {
            static public string MaBan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button1.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button1.Text.ToString());
            if (TinhTrang == 1)
                button1.BackColor = Color.IndianRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button2.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button2.Text.ToString());
            if (TinhTrang == 1)
                button2.BackColor = Color.IndianRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button3.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button3.Text.ToString());
            if (TinhTrang == 1)
                button3.BackColor = Color.IndianRed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button4.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button4.Text.ToString());
            if (TinhTrang == 1)
                button4.BackColor = Color.IndianRed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button5.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button5.Text.ToString());
            if (TinhTrang == 1)
                button5.BackColor = Color.IndianRed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button6.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button6.Text.ToString());
            if (TinhTrang == 1)
                button6.BackColor = Color.IndianRed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button7.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button7.Text.ToString());
            if (TinhTrang == 1)
                button7.BackColor = Color.IndianRed;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button8.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button8.Text.ToString());
            if (TinhTrang == 1)
                button8.BackColor = Color.IndianRed;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button9.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button9.Text.ToString());
            if (TinhTrang == 1)
                button9.BackColor = Color.IndianRed;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button10.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button10.Text.ToString());
            if (TinhTrang == 1)
                button10.BackColor = Color.IndianRed;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button11.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button11.Text.ToString());
            if (TinhTrang == 1)
                button11.BackColor = Color.IndianRed;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string err = "";
            LuuMaBan.MaBan = button12.Text.ToString();
            Form x = new FormMenuOrder();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            int TinhTrang = dbban.CheckTinhTrangBan(ref err, button12.Text.ToString());
            if (TinhTrang == 1)
                button12.BackColor = Color.IndianRed;
        }
    }
}
