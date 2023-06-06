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
        private void customizeDesing () 
        {
            panelBanSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if(panelBanSubMenu.Visible == true )
                panelBanSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false )
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else 
                subMenu.Visible = false;     
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanSubMenu);
        }

        private void btnInBill_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
