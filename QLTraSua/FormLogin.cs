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
    public partial class FormLogin : Form
    {
        SqlConnection conn;
        string strConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLQUANTRASUA;"
            + "Integrated Security=True";
        SqlCommand com;
        public FormLogin()
        {   
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = "Select TaiKhoan, MatKhau From DangNhap ";
                cmd += "where TaiKhoan='" + txtUser.Text.Trim() + "'";
                cmd += " and MatKhau='" + txtPass.Text.Trim() + "'";
                com.CommandText = cmd;
                SqlDataReader check = com.ExecuteReader();

                if (check.HasRows)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                com = new SqlCommand();
                com.Connection = conn;
                txtPass.PasswordChar = '*';
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
