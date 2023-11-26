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
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            using (Form_FinishOrder uf = new Form_FinishOrder())
            {
                uf.ShowDialog();
            }
        }
    }
}
