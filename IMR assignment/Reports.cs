using System;
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
    public partial class Reports : Form
    {
        Function con;
        public Reports()
        {
            InitializeComponent();
            con = new Function();
            showreport();
        }

        private void Reports_Load(object sender, EventArgs e)
        {



        }
        private void showreport()
        {
            try
            {
                string query = "SELECT * FROM dbo.EmployeeSalesReport;";
                ReportDGV.DataSource = con.GetData(query); // Assign data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        private void ReportDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
