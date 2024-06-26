﻿using System;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void AddControl(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControl(new View.frmCategoryView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControl(new View.frmProductView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControl(new View.frmStaffView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddControl(new View.frmCustomerView());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AddControl(new View.frmReportView());
        }
    }
}
