﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLS;

namespace POS_System
{
    public partial class ViewExpiry : UserControl
    {
        public ViewExpiry()
        {
            InitializeComponent();
        }
        BLLDamage bldmg = new BLLDamage();
        private void btnsearch_Click(object sender, EventArgs e)
        {

            if (txtproduct.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                dt = bldmg.getexpiryproductbyproductname(txtproduct.Text);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Product Does Not Found");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Text Box");
            }
        }
        public void viewallexpiry()
        {
            DataTable dt = new DataTable();
            dt = bldmg.getallexpiryproduct();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
