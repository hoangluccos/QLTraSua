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
    public partial class FormInBill : Form
    {
        public FormInBill()
        {
            InitializeComponent();
        }
        public string KiemTraTinhTrang(string MaBan)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLQUANTRASUA;"
               + "Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT dbo.CheckTinhTrang(@MaBan)", conn);

            cmd.Parameters.AddWithValue("@MaBan", MaBan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string str = dt.Rows[0][0].ToString();
            return str;
        }

        public void DoiMau(string MaBan, Button x)
        {
            int TinhTrang = 0;
            TinhTrang = Convert.ToInt32(KiemTraTinhTrang(MaBan.ToString()));

            //MessageBox.Show(TinhTrang.ToString());

            if (TinhTrang == 1)
                x.BackColor = Color.IndianRed;
            else
                x.BackColor = Color.Transparent;
        }

        public class LuuMaBan
        {
            static public string MaBan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuuMaBan.MaBan = button1.Text.ToString();
            Form x = new FormThongTinBill();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            DoiMau(button1.Text.ToString(), button1);
            DoiMau(button2.Text.ToString(), button2);
            DoiMau(button3.Text.ToString(), button3);
            DoiMau(button4.Text.ToString(), button4);
            DoiMau(button5.Text.ToString(), button5);
            DoiMau(button6.Text.ToString(), button6);
            DoiMau(button7.Text.ToString(), button7);
            DoiMau(button8.Text.ToString(), button8);
            DoiMau(button9.Text.ToString(), button9);
            DoiMau(button10.Text.ToString(), button10);
            DoiMau(button11.Text.ToString(), button11);
            DoiMau(button12.Text.ToString(), button12);
        }
    }

}
