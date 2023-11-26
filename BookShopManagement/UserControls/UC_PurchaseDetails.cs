﻿using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_PurchaseDetails : UserControl
    {
        public UC_PurchaseDetails()
        {
            InitializeComponent();
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook abn = new Form_AddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            using (Form_AddStock ads = new Form_AddStock())
            {
                ads.ShowDialog();
            }
        }
    }
}
