using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookShopManagement.UserControls
{
    public partial class UC_ManageExpense : UserControl
    {
        public UC_ManageExpense()
        {
            InitializeComponent();
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense ae = new Form_AddExpense())
            {
                ae.ShowDialog();
            }
        }
    }
}
