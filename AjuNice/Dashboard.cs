using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace AjuNice
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            this.Load += new EventHandler(Dashboard_Load);
        }

        public class Order
        {
            public string OrderID { get; set; }
            public string Time { get; set; }
            public string Items { get; set; }
            public string Total { get; set; }
            public string Status { get; set; }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadRecentOrders();
        }

        private void LoadRecentOrders()
        {
            List<Order> recentOrdersList = new List<Order>()
            {
                new Order { OrderID = "ORD-001", Time = "05:15 PM", Items = "Classic Burger Combo x2", Total = "₱360.00", Status = "Completed" },
                new Order { OrderID = "ORD-002", Time = "05:19 PM", Items = "Cheese Overload Burger", Total = "₱180.00", Status = "Pending" },
                new Order { OrderID = "ORD-003", Time = "05:30 PM", Items = "Bacon & Mushroom Meal", Total = "₱240.00", Status = "Preparing" }
            };

            dgvRecentOrders.AutoGenerateColumns = true;
            dgvRecentOrders.DataSource = recentOrdersList;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Create an instance of your Reports form
            Reports rep = new Reports();

            // 2. Position it exactly where the Dashboard currently is to prevent screen jumping
            rep.StartPosition = FormStartPosition.Manual;
            rep.Location = this.Location;

            // 3. Hide the Dashboard and show the Reports form
            this.Hide();
            rep.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_2(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userManagement manage = new userManagement();

            // 2. Set the position so it doesn't jump around the screen
            manage.StartPosition = FormStartPosition.Manual;
            manage.Location = this.Location;

            // 3. Hide the Dashboard and show the Management form
            this.Hide();
            manage.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard dash = new Dashboard();

            // 2. Keep the window in the same spot on the screen
            dash.StartPosition = FormStartPosition.Manual;
            dash.Location = this.Location;

            // 3. Close or Hide this form and show the Dashboard
            this.Hide();
            dash.Show();
        }
    }
}