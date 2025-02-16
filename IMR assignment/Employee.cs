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
    public partial class Employee : Form
    {
        Function con;
        public Employee()
        {
            InitializeComponent();
            con = new Function();
            showskills();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
        private void showskills()
        {
            try
            {
                string query = "SELECT * FROM dbo.BranchPerformance;";
                EmployeeDGV.DataSource = con.GetData(query); // Assign data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
