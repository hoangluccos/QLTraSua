﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelBanSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelBanSubMenu.Visible == true)
                panelBanSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanSubMenu);
        }

        private void btnInBill_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new FormInBill());

        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBancs());
            hideSubMenu();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDoanhThu());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNhapHang());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHoaDon());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHelp());

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Form x = new FormLogin();
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }
    }
}
