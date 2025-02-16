using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IMR_assignment
{
    public partial class Home : Form
    {
        Function con; // Custom helper class for database operations

        public Home()
        {
            InitializeComponent();
            con = new Function();
            showbill(); // Display data on form load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Additional setup can go here
        }

        // Method to fetch and display data in a DataGridView
        private void showbill()
        {
            try
            {
                string query = "SELECT * FROM dbo.Cashier_View;";
                Cashior.DataSource = con.GetData(query); // Assign data to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
