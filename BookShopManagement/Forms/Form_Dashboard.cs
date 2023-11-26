using BookShopManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {
        int panelWidth;
        bool isCollapsed;
        
        public Form_Dashboard()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
            panelSide.Visible = false;
            timerTime.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width += 10;
                if (panelLeft.Width>=panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width<=56)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonHome_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void buttonSellBooks_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonSellBooks);
            UC_Sales us = new UC_Sales();
            AddControlsToPanel(us);
        }

        private void buttonPurchaseItems_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonPurchaseItems);
            UC_PurchaseDetails up = new UC_PurchaseDetails();
            AddControlsToPanel(up);
        }

        private void buttonExpenses_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonExpenses);
            UC_ManageExpense me = new UC_ManageExpense();
            AddControlsToPanel(me);
        }

        private void buttonSettings_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonSettings);
        }

        private void buttonViewSales_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonViewSales);
            UC_ViewSales vs = new UC_ViewSales();
            AddControlsToPanel(vs);
        }

        private void buttonUsers_Enter(object sender, EventArgs e)
        {
            MoveIndicator(buttonUsers);
            UC_ManageUser um = new UC_ManageUser();
            AddControlsToPanel(um);
        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("hh:mm:ss");

        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void MoveIndicator(Control btn)
        {
            panelSide.Visible = true;
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
    }
}
