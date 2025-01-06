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
using Mysqlx.Resultset;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GPOS
{
    public partial class Billing : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Billing()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            DisplayProducts();
       CheckDailySales();
            //   UpdateSalesLabel();
            //getCustomer();
         //   //GetCusName();
           // checkMonthlySales();
           CheckMonthlySales();
           ProductsDVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDVG.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            ProductsDVG.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        }
        public void CheckDailySales()
        {
            decimal totalSales = 0m;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int totalQuantity = 0;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


            ////
            ///



            using (MySqlConnection con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;"))
            {
                string query = "SELECT SUM(Amt) AS TotalSales FROM BillT WHERE DATE(BDate) =  CURDATE()";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {

                    //con.Open();
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                         //   textBox1.Text = totalSales.ToString("N2");
                            textBox2.Text = "GH₵" + " " + totalSales.ToString("N2");
                            //   totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                        }
                    }
                }
            }

         //   MessageBox.Show($"Total Sales for Today: GH¢ {totalSales}", "Daily Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  MessageBox.Show($"Daily Sales is GH¢: {totalSales}", "Daily Sales");

            // MBox1.Show("Total Sales for Today: GHS '"++"');

        }


        private void label14_Click(object sender, EventArgs e)
        {

        }
        //string CustomerName;
        private void SupName_TextChanged(object sender, EventArgs e)
        {
            getCustomer();
        }
        string productName;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SupAdd_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //search production btn

        private void button3_Click(object sender, EventArgs e)
        {
            string searchTerm = Search.Text.Trim();
            SearchProducts(searchTerm);
        }


        private void SearchProducts(string searchTerm)
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductTbl WHERE PName LIKE @SearchTerm";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
                adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ProductsDVG.DataSource = dt;
             //   ProductsDVG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // Example event handler for a search button or search box text change




        private void label11_Click(object sender, EventArgs e)
        {

        }



        //SqlConnection Con = MyDBConnection.GetConnected();


        //billing view grid 
        MySqlConnection Con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;");

        private void DisplayProducts()

        {
            Con.Open();
            string Query = "select * from ProductTbl";
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            // we fill data grid with the acutal data in db
            ProductsDVG.DataSource = ds.Tables[0];


            ProductsDVG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Con.Close();

        }
        int keyMain = 0;
        string PnameTb;
        //PStock is tracking the remaining stock
        float Pprice;
        int PStock;
        float total;
        int n = 0;

        private void Reset()
        {
            PnameTb = "";
            Quantity.Text = "";
            keyMain = 0;


        }

        private void UpdateSalesLabel(object sender, EventArgs e)
        {
            
        }
        /*
        private void checkMonthlySales()
        {
            string connectionString = "server=localhost; database=posdb; username=root; password=;";
            string query = @"
            SELECT 
                DATE_FORMAT(NOW(), '%Y-%m') AS current_month,
                SUM(Amt) AS accumulated_sales
            FROM 
                billt
            WHERE 
                DATE_FORMAT(STR_TO_DATE (Bdate, '%Y-%m') = DATE_FORMAT(NOW(), '%Y-%m');
        ";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        decimal accumulatedSales = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        label7.Text = $"Current Month Sales: {accumulatedSales:C}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



        }
        */

        public void CheckMonthlySales()
        {
            decimal totalSales = 0m;
            int totalQuantity = 0;

            string connectionString = "server=localhost; database=posdb; username=root; password=;";
            string query = @"
        SELECT 
            SUM(Amt) AS TotalSales, 
            COUNT(*) AS TotalQuantity 
        FROM 
            BillT 
        WHERE 
            MONTH(BDate) = MONTH(CURDATE()) 
            AND YEAR(BDate) = YEAR(CURDATE());
    ";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                                totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                                //  totalSales = label7.Text;
                                textBox1.Text = "GH₵" + " " + totalSales.ToString("N2");

                              //  label7.Text += totalSales;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Del()
        {
            SubTotal.Text = "";
            VATtb.Text = "";
            discountTb.Text = "";
            //  SubTotal = 0
            // Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
        }


        private void getCustomer()
        {
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("Select CusId from CustomerTbl", Con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CusId", typeof(int));
            dt.Load(rdr);
            CusIDCB.ValueMember = "CusId";
            CusIDCB.DataSource = dt;


            Con.Close();
        }
        //int total = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            {
                // Check if no product is selected
                if (keyMain == 0)
                {
                    // Show a message box prompting the user to select a product
                    MBox1.Show("Select A Product");
                }
                else if (Quantity.Text == "")
                {
                    MBox1.Show("Enter the quantity");
                }
                else if (Convert.ToInt32(Quantity.Text) > PStock)
                {
                    MBox1.Show("No Enough Stock");
                }
                else
                {
                    // Calculate the subtotal for the selected product
                     float Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
                    total = total + Subtotal;
                    //    
                    //double Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
                    //total = total + (float)Subtotal;


                    // Create a new row for the DataGridView
                    DataGridViewRow newRow = new DataGridViewRow();

                    // Initialize the new row with the appropriate number of cells for the SupplierDGV
                    newRow.CreateCells(BillDGV);

                    // Set the value of the first cell to the variable 'n'
                    // This might be an index or counter, but its definition is not provided in this snippet
                    newRow.Cells[0].Value = n;
                // Set the value of the second cell to the product name from the PnameTb TextBox
                    newRow.Cells[1].Value = PnameTb;

                    // Set the value of the third cell to the quantity from the Quantity TextBox
                    newRow.Cells[2].Value = Quantity.Text;

                    // Set the value of the fourth cell to the product price (Pprice)
                    newRow.Cells[3].Value = Pprice;

                    // Set the value of the fifth cell to the calculated subtotal
                    newRow.Cells[4].Value = Subtotal;
                    ResetButtonColor();
                    // Add the new row to the SupplierDGV DataGridView
                    BillDGV.Rows.Add(newRow);
                    SubTotal.Text = "" + total;
                    UpdateQuantity();
                    n++;
                    Reset();
                }
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // setting/getting  data in datagrid to fit text box for edit RESPECTIVELY 
            //if (customerDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //SelectedRows.Count > 0 && ProductsDVG.SelectedRows[0].Cells[1].Value
            if (ProductsDVG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
            }
            else
            {
                // Handle the case where no row is selected or the cell value is null
                MessageBox.Show("Please select a valid row with a valid product name.");
                PnameTb = string.Empty; // or some other default value
            }




            //PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
            //PcatCB.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            Pprice = Convert.ToSingle(ProductsDVG.SelectedRows[0].Cells[3].Value.ToString());
            PStock = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[4].Value.ToString());

            
            if (PnameTb == "")
            {

                keyMain = 0;
            }
            else
            {

                keyMain = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[0].Value.ToString());
                AddBtn.BackColor = Color.ForestGreen;
            }


        }
        private void ResetButtonColor()
        {
            AddBtn.BackColor = Color.Teal; 
        }// Reset to default button color }
        private void UpdateQuantity()
        {
            int newQty = PStock - Convert.ToInt32(Quantity.Text);
            try
            {
                // we open db connection 
                Con.Open();
                MySqlCommand cmd = new MySqlCommand(" Update ProductTbl set PQty = @PQ  where PId = @Pkey", Con);

                cmd.Parameters.AddWithValue("@PQ", newQty);
                cmd.Parameters.AddWithValue("@Pkey", keyMain);

                cmd.ExecuteNonQuery();
                //MBox1.Show("Supplier Detail Updated");
                Con.Close();
                DisplayProducts();
                //  Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertBill();
            CheckDailySales();
            CheckMonthlySales();    


            if (bflag == 1)
            {
                // Set the paper size for printing
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

                // Debugging statement before showing the print preview dialog
                Console.WriteLine("Showing print preview dialog...");
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Debugging statement before printing
                    Console.WriteLine("Print preview OK clicked, starting print...");
                    printDocument1.Print();
                    CusIDCB.SelectedIndex = -1;
                    CusNameCB.Text = "";
                    Del();


                }
            }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            Search.Text = "";
        }



        private void SupplierDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CusIDCB_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CusIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  GetCusName();
        }

        private void VATtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void VATtb_MouseLeave(object sender, EventArgs e)
        {

        }

        private void VATtb_KeyDown(object sender, KeyEventArgs e)
        {

        }
        int bflag = 0;
        string getName;


        private void InsertBill()
        {



            if (CusIDCB.SelectedIndex == -1 || PaymentCB.SelectedIndex == -1 || GrdTotal.Text == "")
            {
                MBox1.Show("All fields are required ");
            }
            else
            {
                try
                {
                    // we open db connection 
                    foreach (DataGridViewRow row in BillDGV.Rows)
                    {

                        if (row.Cells["Column2"].Value != null)
                        {
                            getName = row.Cells["Column2"].Value.ToString(); // This will take the last value
                                                                             //    Console.WriteLine($"getName: {getName}");
                        }
                    }


                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand(" insert into BillT(BDate, CustId, CustName, PMethod, Amt, ProductName) values(@BD, @CI, @CN, @PM, @AM, @PN)", Con);
                    cmd.Parameters.AddWithValue("@BD", BDateCB.Value.Date);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@CI", CusIDCB.SelectedValue.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    //cmd.Parameters.AddWithValue("@CN", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@CN", CusNameCB.Text);
                    cmd.Parameters.AddWithValue("@PN", getName);
                    //  cmd.Parameters.AddWithValue("@PN", productName);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PM", PaymentCB.SelectedItem.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@AM", Convert.ToDouble(GrdTotal.Text));

                    cmd.ExecuteNonQuery();
                    // MBox1.Show("Bill saved");


                    bflag = 1;
                    Con.Close();
                    //Reset();
                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                }
            }
        }




        private void VATtb_KeyUp(object sender, KeyEventArgs e)
        {

            if (VATtb.Text == "")
            {

            }
            else if (SubTotal.Text == "")
            {
                MBox1.Show("Add Products to Cart ");
                VATtb.Text = "";
            }
            else
            {
                try
                {



                    float VAT = (Convert.ToSingle(VATtb.Text) / 100) * Convert.ToSingle(SubTotal.Text);
                   // int getvat = Convert.ToInt32(VATtb.Text) = 0);
                   // float VAT = getvat * Convert.ToSingle(SubTotal.Text);

                    TotTaxTb.Text = VAT.ToString();
      //              VAT = 0;
                    GrdTotal.Text = "" + (Convert.ToSingle(SubTotal.Text) + Convert.ToSingle(TotTaxTb.Text));

                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);

                }
            }

        }


        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (discountTb.Text == "")
            {

            }
            else if (SubTotal.Text == "")
            {
               // MBox1.Show("Add Products to Cart ");
                MessageBox.Show("Add Products to Cart ");
                discountTb.Text = "";
            }
            else
            {
                try
                {

                    float Disc = (Convert.ToSingle(discountTb.Text) / 100) * Convert.ToSingle(SubTotal.Text);
                    // TotalDiscount.Text = "" + Disc;
                 //   discountTb.Text += 0;
                    TotalDiscount.Text = Disc.ToString();

                    GrdTotal.Text = "" + (Convert.ToSingle(SubTotal.Text) + Convert.ToSingle(TotTaxTb.Text) - Convert.ToSingle(TotalDiscount.Text));



                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                    MessageBox.Show(Ex.ToString());

                }
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
#pragma warning disable CS8602 //1   Dereference of a possibly null reference.
            //    e.Graphics.DrawString("AHAVAH ODO", new Font("Centry Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(70, 10));
            //  e.Graphics.DrawString("ENTERPRISE", new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(60, 12));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            
            string contact = "Tel:+233 247 557 094 ";
            string subtitle = "OVER-THE-COUNTER DRUGSTORE";
            //string heading = "ID PRODUCT PRICE QUANTITY TOTAL";

            // Get the width of the printable area
            int printableWidth = e.PageBounds.Width;

            // Calculate positions to center text
            int titleX = (printableWidth / 2) - (int)e.Graphics.MeasureString("EVANSVIC ", new Font("Century Gothic", 10, FontStyle.Bold)).Width / 2;
            int subtitleX = (printableWidth / 2) - (int)e.Graphics.MeasureString(subtitle, new Font("Century Gothic", 6, FontStyle.Bold)).Width / 2;
            int contactX = (printableWidth / 2) - (int)e.Graphics.MeasureString(contact, new Font("Century Gothic", 6, FontStyle.Bold)).Width / 2;
            //  int headingX = (printableWidth / 2) - (int)e.Graphics.MeasureString(heading, new Font("Century Gothic", 8, FontStyle.Bold)).Width / 2;
            string location = "Loc: Jema, Kintampo South";
            int gap = 40;
            // Draw the text
            e.Graphics.DrawString("EVANSVIC", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(titleX + 10, 7));
            e.Graphics.DrawString(subtitle, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(subtitleX, 22));
            e.Graphics.DrawString(contact, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(contactX, 32));
           // e.Graphics.DrawString(location, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(50 + 15, 42));
            e.Graphics.DrawString("Location: Kintampo South, Jema", new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(40 + gap, 42));

            e.Graphics.DrawString("___________________________________________________", new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(40, 48));
            e.Graphics.DrawString("___________________________________________________", new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(40, 52));

            // Add vertical spacing between heading and ID product line

            // e.Graphics.DrawString(heading, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(headingX, 80));

            e.Graphics.DrawString("ID PRODUCT QUANTITY PRICE  TOTAL", new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(36, 68));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);





                // e.Graphics.DrawString("" + prodid, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(50, pos + 40));
                e.Graphics.DrawString("" + prodname, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(45, pos + 40));
                e.Graphics.DrawString(" " + prodprice, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(120, pos + 40));
                e.Graphics.DrawString("" + prodqty, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(170, pos + 40));
                e.Graphics.DrawString("" + tottal, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(235, pos + 40));



                pos = pos + 40;


            }
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int lineSpacing = 20;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            e.Graphics.DrawString("******Powered by: GrockTech Consult******", new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(50, pos + 80));


            e.Graphics.DrawString("Grand Total: GH¢" + GrdTotal.Text + ".00", new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 40));
            //e.Graphics.DrawString("***************************GrockTech Consult**********************" , new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50 + lineSpacing));
            e.Graphics.DrawLine(Pens.Black, new Point(50, pos + 70), new Point(250, pos + 70));

            // Draw the footer text

            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            //Del();
            pos = 100;
            GrdTotal.Text = "";
            //  tot n  = 0;
            total = 0;
            SubTotal.Text = "";

            n = 0;


            //    Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;



        }

        private void label8_Click(object sender, EventArgs e)
        {
            ViewBill obj = new ViewBill();
            obj.Show();
            // this.Close();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
     /* private void retrieveSale()
        {
            string querry =@"SELECT
  DATE_FORMAT(STR_TO_DATE(transaction_date, '%Y-%m-%d'), '%Y-%m') AS month,
  SUM(amount) AS total_sales
FROM
  sales_transactions
WHERE
  YEAR(STR_TO_DATE(transaction_date, '%Y-%m-%d')) = YEAR(CURDATE()) AND
  MONTH(STR_TO_DATE(transaction_date, '%Y-%m-%d')) = MONTH(CURDATE())
GROUP BY
  DATE_FORMAT(STR_TO_DATE(transaction_date, '%Y-%m-%d'), '%Y-%m');
            ";
        }
       */

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BillDGV.Rows.Clear();
            // int zero = 0;
            total = 0;
            SubTotal.Text = "";

        }

        private void VATtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                // Check if the character is a digit or a decimal point
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Ignore the input
                }

                // Optional: Prevent multiple decimal points
                if (e.KeyChar == '.' && VATtb.Text.Contains('.'))
                {
                    e.Handled = true; // Ignore the input
                }
            }
        }

        private void discountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                // Check if the character is a digit or a decimal point
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Ignore the input
                }

                // Optional: Prevent multiple decimal points
                if (e.KeyChar == '.' && discountTb.Text.Contains('.'))
                {
                    e.Handled = true; // Ignore the input
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VATtb.Text = "";
            discountTb.Text = "";
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expiring exp = new Expiring();
            exp.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
