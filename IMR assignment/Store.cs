﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMR_assignment
{
    public partial class Store : Form
    {
        Function con;
        public Store()
        {
            InitializeComponent();
            con = new Function();
            showproducts();
        }

        private void Store_Load(object sender, EventArgs e)
        {


        }
        private void showproducts()
        {
            try
            {
                string query = "SELECT * FROM dbo.StockMonitoring;";
                StoreDGV.DataSource = con.GetData(query); // Assign data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
