using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPOS
{
    public partial class MonthlyBreakdown : Form
    {
        public MonthlyBreakdown()
        {
            InitializeComponent();
        }
        private void LoadMonthlySales()
        {
            // Connection string: Replace with your actual connection string
            string connectionString = "server=localhost; database=posdb; username=root; password=;";

            // SQL query
            string query = @"
                SELECT 
                    DATE_FORMAT(Bdate, '%M %Y') AS Month, 
                    SUM(Amt) AS TotalSales
                FROM 
                    billt
                GROUP BY 
                    DATE_FORMAT(Bdate, '%M %Y')
                ORDER BY 
                    Month;";

            // Load data into a DataTable
            DataTable monthlySalesTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                connection.Open();
                adapter.Fill(monthlySalesTable);
            }

            // Bind data to DataGridView
            dataGridView1.DataSource = monthlySalesTable;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthlyBreakdown_Load(object sender, EventArgs e)
        {
            LoadMonthlySales();
        }
    }
}
