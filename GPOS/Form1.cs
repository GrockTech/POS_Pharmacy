using ClosedXML.Report.Excel;
using MySql.Data.MySqlClient;
//using OfficeOpenXml;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using OfficeOpenXml;

namespace GPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getDetails();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;");
        private void getDetails()
        {
            //

            Con.Open();
            string Query = "SELECT Id, ProductName, Date, Price, Quantity, Subtotal FROM billdetails";
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
            // adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CopyToCB()
        {
            try
            {
                string headers = "";
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    headers += column.HeaderText + "\t";
                }
                headers = headers.TrimEnd('\t');

                Clipboard.SetText(headers);
                dataGridView1.SelectAll();
                DataObject obj = dataGridView1.GetClipboardContent();
                if (obj != null)
                    Clipboard.SetDataObject(obj);
                else
                    MessageBox.Show("Dataset is empty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                CopyToCB();
                Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlwb;
                Microsoft.Office.Interop.Excel.Worksheet xlsh;
                Microsoft.Office.Interop.Excel.Range xlr;

                object mv = System.Reflection.Missing.Value;

                xlwb = xls.Workbooks.Add(mv);
                xlsh = xlwb.Worksheets[1];

                // Define column headers (adjust column names as needed)

                //xlsh.Cells[1, 1] = "Product Name";
                //xlsh.Cells[1, 2] = "Date";
                //xlsh.Cells[1, 3] = "Quantity";
                //xlsh.Cells[1, 4] = "Price";
                //xlsh.Cells[1, 5] = "Subtotal";
                // If you are exporting the date

                // Make headers bold
                xlsh.Range["A1:E1"].Font.Bold = true;

                // Select the first cell below headers
                xlr = xlsh.Cells[2, 1];
                xlr.Select();

                // Paste copied data starting from row 2
                xlsh.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                xls.Visible = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
