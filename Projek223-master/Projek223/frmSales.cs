using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projek223
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Baas\Documents\_TWEEDEJAAR\Projek 223\Projek223-master\Projek223\MicroGreensDatabase1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlDataReader read;
        SqlCommand comm;
        DataSet ds;
        SqlDataAdapter adapt;
        string ID = "";
        decimal total = 0;
        int Sales_ID = 0;

        //Reload datagridviews after changes
        public void RefreshSale()
        {
            try
            {
                string sql = @"SELECT * FROM SALES_INVOICE";
                conn = new SqlConnection(connstring);
                conn.Open();

                comm = new SqlCommand(sql, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Data");

                dataGridView1.DataMember = "Data";
                dataGridView1.DataSource = ds;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Records not found");
            }
        }

        public void RefreshCustomer()
        {
            try
            {
                string sql = @"SELECT * FROM CUSTOMER";
                conn = new SqlConnection(connstring);
                conn.Open();

                comm = new SqlCommand(sql, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Data");

                dataGridView2.DataMember = "Data";
                dataGridView2.DataSource = ds;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Records not found");
            }
        }

        public void RefreshProduct()
        {
            try
            {
                string sql = @"SELECT * FROM PRODUCT";
                conn = new SqlConnection(connstring);
                conn.Open();

                comm = new SqlCommand(sql, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Data");

                dataGridView4.DataMember = "Data";
                dataGridView4.DataSource = ds;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Records not found");
            }
        }

        private void Sales_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox6.Enabled = false;

            //New Sale
            //Fill customer combobox
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string sqlCustomer = @"SELECT * FROM CUSTOMER";

                comm = new SqlCommand(sqlCustomer, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    if (!comboBox1.Items.Contains(read.GetValue(1)))
                    {
                        comboBox1.Items.Add(read.GetValue(1));
                    }
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not fill customer combobox");
            }

            //Fill Add Product comboboxes
            //Load product and description combobox
            try
            {
                conn.Open();
                string sqlProduct = @"SELECT * FROM PRODUCT";

                comm = new SqlCommand(sqlProduct, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    //Variant
                    if (!comboBox2.Items.Contains(read.GetValue(2)))
                    {
                        comboBox2.Items.Add(read.GetValue(2));
                    }
                    //Description
                    if (!comboBox6.Items.Contains(read.GetValue(1)))
                    {
                        comboBox6.Items.Add(read.GetValue(1));
                    }
                }

                conn.Close();

                //Load Quantity combobox
                conn.Open();
                string sqlQuantity = @"SELECT * FROM SALES";

                comm = new SqlCommand(sqlQuantity, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    //Quantity
                    if (!comboBox3.Items.Contains(read.GetValue(2)))
                    {
                        comboBox3.Items.Add(read.GetValue(2));
                    }
                }

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Product comboboxes.");
            }

            //New Sale
            //Load datagridview
            try
            {
                RefreshSale();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Sale datagridview.");
            }

            //Customers
            //Load Datagridview 
            try
            {
                RefreshCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not load Customer datagridview.");
            }

            //Products
            //Load Datagridview
            try
            {
                RefreshProduct();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Customer datagridview.");
            }
        }

        //Fill Add New Sale Listbox
        public void FillListbox()
        {
            errorProvider1.SetError(comboBox2, "");
            errorProvider1.SetError(comboBox6, "");
            errorProvider1.SetError(comboBox3, "");

            if (comboBox2.SelectedItem != null)
            {
                if (comboBox6.SelectedItem != null)
                {
                    if (comboBox3.SelectedItem != null)
                    {
                        try
                        {
                            string description = comboBox6.SelectedItem.ToString();
                            string quantity = comboBox3.SelectedItem.ToString();
                            listBox1.Items.Add(description + "       " + quantity);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Could not fill listbox with inserted data.");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(comboBox3, "Select quantity.");
                        comboBox3.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox6, "Select a description.");
                    comboBox6.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(comboBox2, "Select a variant.");
                comboBox2.Focus();
            }
        }

        //Add Sale Invoice
        private void AddNewSaleCustomer()
        {
            errorProvider1.SetError(comboBox1, "");
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    string customer_id = @"SELECT * FROM CUSTOMER WHERE Customer_Name =  '" + comboBox1.Text + "'";
                    int customer = 0;

                    conn.Open();

                    comm = new SqlCommand(customer_id, conn);
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        customer = read.GetInt32(0);
                    }
                    read.Close();
                    conn.Close();

                    conn.Open();

                    var date = dateTimePicker1.Value.ToShortDateString();

                    string total_cost = total.ToString();

                    string addInvoice = @"INSERT INTO SALES_INVOICE VALUES(@customer, @date, @total) ; SELECT SCOPE_IDENTITY()";


                    comm = new SqlCommand(addInvoice, conn);

                    comm.Parameters.AddWithValue("@customer", customer);
                    comm.Parameters.AddWithValue("@date", date);
                    comm.Parameters.AddWithValue("@total", total);

                    Sales_ID = Convert.ToInt32(comm.ExecuteScalar());

                    conn.Close();

                    MessageBox.Show("Purchase invoice successfully created.");

                    comboBox2.Enabled = true;
                    comboBox6.Enabled = true;
                    comboBox3.Enabled = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Could not add customer to new sale.");
                }
            }
            else
            {
                errorProvider1.SetError(comboBox1, "Select a customer.");
                comboBox1.Focus();
            }
        }

        //Add Sales Product 
        public void AddNewSaleProduct()
        {
            errorProvider1.SetError(comboBox2, "");
            errorProvider1.SetError(comboBox6, "");
            errorProvider1.SetError(comboBox3, "");

            if (comboBox2.SelectedItem != null)
            {
                if (comboBox6.SelectedItem != null)
                {
                    if (int.TryParse(comboBox3.SelectedItem.ToString(), out int quantity))
                    {
                        try
                        {
                            //Select varaiant and price
                            string product_id = @"SELECT * FROM PRODUCT WHERE Variant = '" + comboBox2.Text + "'";
                            int variant = 0;
                            decimal price = 0;

                            conn.Open();
                            comm = new SqlCommand(product_id, conn);
                            read = comm.ExecuteReader();
                            while (read.Read())
                            {
                                variant = read.GetInt32(2);
                                price = read.GetDecimal(3);
                            }
                            read.Close();

                            total = price * quantity;

                            string addOrder = @"INSERT INTO SALES VALUES(@id, @product, @quantity)";

                            comm = new SqlCommand(addOrder, conn);

                            comm.Parameters.AddWithValue("@id", Sales_ID);
                            comm.Parameters.AddWithValue("@product", variant);
                            comm.Parameters.AddWithValue("@quantity", quantity);

                            comm.ExecuteNonQuery();

                            conn.Close();

                            comboBox2.SelectedIndex = -1;
                            comboBox6.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Could not add product.");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(comboBox3, "Select a valid integer for quantity.");
                        comboBox3.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox6, "Select a description.");
                    comboBox6.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(comboBox2, "Select a variant.");
                comboBox2.Focus();
            }
        }

        //Change Sales Invoice
        public void ChangeInvoice()
        {
            errorProvider1.SetError(textBox12, "");
            errorProvider1.SetError(comboBox4, "");
            errorProvider1.SetError(textBox13, "");

            ID = textBox12.Text;
            if (ID != null)
            {
                if (comboBox4.SelectedItem != null)
                {
                    if (double.TryParse(textBox13.Text, out double total))
                    {
                        try
                        {
                            string customer_id = @"SELECT * FROM CUSTOMER WHERE Customer_Name = '" + comboBox4.Text + "'";
                            int customer = 0;

                            conn.Open();

                            comm = new SqlCommand(customer_id, conn);
                            read = comm.ExecuteReader();
                            while (read.Read())
                            {
                                customer = read.GetInt32(0);
                            }
                            read.Close();


                            string date = dateTimePicker2.Value.ToShortDateString();


                            string changeOrder = @"UPDATE SALES_INVOICE SET Sales_Order_Date = @date, Customer_ID = @id, Total_Cost = @cost WHERE SALES_ORDER_ID = '" + int.Parse(textBox12.Text) + "'";

                            comm = new SqlCommand(changeOrder, conn);

                            comm.Parameters.AddWithValue("@date", date);
                            comm.Parameters.AddWithValue("@id", customer);
                            comm.Parameters.AddWithValue("@cost", total);

                            comm.ExecuteNonQuery();

                            RefreshSale();

                            textBox12.Text = "";
                            comboBox4.SelectedIndex = -1;
                            textBox13.Text = "";

                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Could not change sales invoice");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox13, "Enter a valid integer.");
                        textBox13.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox4, "Select a customer to change.");
                    comboBox4.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox12, "Select an record to change.");
                textBox12.Focus();
            }
        }

        //Change Sales Order
        public void ChangeInvoiceProduct()
        {
            errorProvider1.SetError(textBox4, "");
            errorProvider1.SetError(textBox5, "");

            if (textBox4.Text != "")
            {
                if (int.TryParse(textBox5.Text, out int quantity))
                {
                    try
                    {
                        string product_id = @"SELECT * FROM PRODUCT WHERE Product = '" + textBox4.Text + "'";

                        int product = 0;

                        conn.Open();

                        comm = new SqlCommand(product_id, conn);

                        read = comm.ExecuteReader();
                        while (read.Read())
                        {
                            product = read.GetInt32(0);
                        }
                        read.Close();

                        string changeOrder = @"UPDATE SALES_ORDER SET Item_ID = @item, Quantity_Bought = @quantity WHERE SALES_ORDER_ID = '" + int.Parse(textBox12.Text) + "'";

                        comm = new SqlCommand(changeOrder, conn);

                        comm.Parameters.AddWithValue("product", product);
                        comm.Parameters.AddWithValue("@quantity", quantity);

                        comm.ExecuteNonQuery();

                        conn.Close();

                        textBox4.Text = "";
                        textBox5.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Could not change sales invoice");
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox5, "Enter a valid integer");
                    textBox5.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox4, "Enter a product name");
                textBox4.Focus();
            }
        }

        //Add Customer
        public void AddCustomer()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            errorProvider1.SetError(maskedTextBox1, "");
            errorProvider1.SetError(maskedTextBox2, "");

            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (maskedTextBox1.Text != "")
                    {
                        if (maskedTextBox2.Text != "")
                        {
                            try
                            {
                                conn.Open();

                                string name = textBox1.Text;
                                string surname = textBox2.Text;
                                string cell = maskedTextBox1.Text;
                                string email = maskedTextBox2.Text;

                                string SqlInsertCustomer = @"INSERT INTO CUSTOMER VALUES(@Name, @Surname, @Cell, @Email)";

                                comm = new SqlCommand(SqlInsertCustomer, conn);

                                comm.Parameters.AddWithValue("@Name", name);
                                comm.Parameters.AddWithValue("@Surname", surname);
                                comm.Parameters.AddWithValue("@Cell", cell);
                                comm.Parameters.AddWithValue("@Email", email);

                                comm.ExecuteNonQuery();

                                RefreshCustomer();

                                MessageBox.Show("Customer successfully added.");
                                conn.Close();
                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show(error.Message, "Could not add Customer");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(maskedTextBox2, "Enter valid email address.");
                            maskedTextBox2.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(maskedTextBox1, "Enter a contact number.");
                        maskedTextBox1.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox2, "Enter supplier customer surname.");
                    textBox2.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Enter a supllier name.");
                textBox1.Focus();
            }
        }

        //Change Customer
        public void ChangeCustomer()
        {
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(textBox4, "");
            errorProvider1.SetError(textBox14, "");
            errorProvider1.SetError(textBox16, "");
            errorProvider1.SetError(textBox15, "");

            ID = textBox3.Text;
            if (ID != null)
            {
                if (textBox4.Text != "")
                {
                    if (textBox14.Text != "")
                    {
                        if (textBox16.Text != "")
                        {
                            if (textBox15.Text != "")
                            {
                                try
                                {
                                    conn.Open();

                                    string name = textBox4.Text;
                                    string surname = textBox14.Text;
                                    string cell = textBox16.Text;
                                    string email = textBox15.Text;

                                    string changeCustomer = @"UPDATE CUSTOMER SET Customer_Name = @name, Customer_Surname = @surname, Customer_Number = @cell, Customer_Email = @email WHERE Customer_ID = '" + int.Parse(textBox3.Text) + "'";

                                    comm = new SqlCommand(changeCustomer, conn);

                                    comm.Parameters.AddWithValue("@name", name);
                                    comm.Parameters.AddWithValue("@surname", surname);
                                    comm.Parameters.AddWithValue("@cell", cell);
                                    comm.Parameters.AddWithValue("@email", email);

                                    comm.ExecuteNonQuery();
                                    RefreshCustomer();

                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Could not change customer");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(textBox15, "Enter a customer email address.");
                                textBox15.Focus();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(textBox16, "Enter a customer contact number.");
                            textBox16.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox14, "Enter a customer surname to change.");
                        textBox14.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox4, "Enter a customer name to change.");
                    textBox4.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox3, "Select a record to change.");
                textBox3.Focus();
            }

        }

        //Add Product
        public void AddProduct()
        {
            errorProvider1.SetError(comboBox5, "");
            errorProvider1.SetError(maskedTextBox7, "");
            errorProvider1.SetError(maskedTextBox8, "");

            if (comboBox5.SelectedItem != null)
            {
                if (maskedTextBox7.Text != "")
                {
                    if (double.TryParse(maskedTextBox8.Text, out double price))
                    {
                        try
                        {
                            conn.Open();

                            string variant = comboBox5.Text;
                            string desc = maskedTextBox7.Text;

                            string SqlInsertProduct = @"INSERT INTO PRODUCT VALUES(@Desc, @Product, @Price)";

                            comm = new SqlCommand(SqlInsertProduct, conn);

                            comm.Parameters.AddWithValue("@Desc", desc);
                            comm.Parameters.AddWithValue("@Item", variant);
                            comm.Parameters.AddWithValue("@Price", price);

                            comm.ExecuteNonQuery();

                            RefreshProduct();

                            MessageBox.Show("Product successfully added.");
                            conn.Close();
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "Could not add Product");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(maskedTextBox8, "Enter a valid price.");
                        maskedTextBox8.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(maskedTextBox7, "Enter a description.");
                    maskedTextBox7.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(comboBox5, "Select a variant.");
                comboBox5.Focus();
            }
        }

        //Change Poduct
        public void ChangeProduct()
        {
            errorProvider1.SetError(textBox13, "");
            errorProvider1.SetError(comboBox4, "");
            errorProvider1.SetError(textBox12, "");
            errorProvider1.SetError(textBox11, "");

            ID = textBox13.Text;
            if (ID != null)
            {
                if (comboBox4.SelectedItem != null)
                {
                    if (textBox12.Text != "")
                    {
                        if (double.TryParse(textBox11.Text, out double price))
                        {
                            try
                            {
                                string product_id = @"SELECT Variant FROM PRODUCT WHERE Product_ID = '" + textBox13.Text + "'";

                                int productID = 0;

                                conn.Open();

                                comm = new SqlCommand(product_id, conn);
                                read = comm.ExecuteReader();
                                while (read.Read())
                                {
                                    productID = read.GetInt32(0);
                                }
                                read.Close();

                                string variant = comboBox4.SelectedItem.ToString();
                                string desc = textBox12.Text;

                                string updateProduct = @"UPDATE PRODUCT SET Product_Description = @desc, Variant = @variant, Product_Price = @price WHERE Product_ID = '" + int.Parse(textBox13.Text) + "'";

                                comm = new SqlCommand(updateProduct, conn);

                                comm.Parameters.AddWithValue("@desc", desc);
                                comm.Parameters.AddWithValue("@product", variant);
                                comm.Parameters.AddWithValue("@price", price);

                                comm.ExecuteNonQuery();
                                RefreshProduct();

                                conn.Close();

                                textBox13.Text = "";
                                comboBox4.Text = "";
                                textBox12.Text = "";
                                textBox11.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Could not change product");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(textBox11, "Enter price to change.");
                            textBox11.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox12, "Enter description to change.");
                        textBox12.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox4, "Select product to change.");
                    comboBox4.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox13, "Select a record to change.");
                textBox13.Focus();
            }
        }

        //Buttons and Click events
        private void label24_Click(object sender, EventArgs e)
        {
            AddNewSaleCustomer();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            AddNewSaleCustomer();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FillListbox();
            AddNewSaleProduct();
        }

        private void lblBTNAddGC_Click(object sender, EventArgs e)
        {
            FillListbox();
            AddNewSaleProduct();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            comboBox2.Enabled = false;
            comboBox6.Enabled = false;
            comboBox3.Enabled = false;

            MessageBox.Show("Sales invoice successfully inserted");

            string customer_id = @"SELECT * FROM CUSTOMER WHERE Customer_Name =  '" + comboBox1.Text + "'";
            int customer = 0;

            conn.Open();

            comm = new SqlCommand(customer_id, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                customer = read.GetInt32(0);
            }
            read.Close();

            string sql = @"UPDATE SALES_INVOICE SET Sales_Order_ID = @SalesID, Sales_Order_Date = @date, Customer_ID = @customer, Total_Payment_Amount = @cost WHERE Sales_Order_ID = '" + Sales_ID + "'";

            comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@Sales_ID", Sales_ID);
            comm.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@customer", customer);
            comm.Parameters.AddWithValue("@cost", total);

            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void label19_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox6.Enabled = false;

            MessageBox.Show("Sales invoice successfully inserted");

            string customer_id = @"SELECT * FROM CUSTOMER WHERE Customer_Name =  '" + comboBox1.Text + "'";
            int customer = 0;

            conn.Open();

            comm = new SqlCommand(customer_id, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                customer = read.GetInt32(0);
            }
            read.Close();

            string sql = @"UPDATE SALES_INVOICE SET Total_Payment_Amount = @cost WHERE Sales_Order_ID = '" + Sales_ID + "'";

            comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@cost", total);

            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox6.Enabled = false;

            MessageBox.Show("Sales invoice successfully inserted");

            string customer_id = @"SELECT * FROM CUSTOMER WHERE Customer_Name =  '" + comboBox1.Text + "'";
            int customer = 0;

            conn.Open();

            comm = new SqlCommand(customer_id, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                customer = read.GetInt32(0);
            }
            read.Close();

            string sql = @"UPDATE SALES_INVOICE SET Total_Payment_Amount = @cost WHERE Sales_Order_ID = '" + Sales_ID + "'";

            comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@cost", total);

            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            ChangeInvoice();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ChangeInvoice();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            ChangeInvoiceProduct();
            dataGridView3.ClearSelection();
            MessageBox.Show("Invoice successfully changed. Click on Change Invoice to change more data.");
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ChangeInvoiceProduct();
            dataGridView3.ClearSelection();
            MessageBox.Show("Invoice successfully changed. Click on Change Invoice to change more data.");
        }

        private void label18_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ChangeCustomer();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            ChangeProduct();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            ChangeProduct();
        }

        //Fill textboxes with datagridview records
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs dg2)
        {
            if (dg2.RowIndex >= 0)
            {
                textBox6.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker2.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                textBox5.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();

                DataGridViewRow row = dataGridView2.Rows[dg2.RowIndex];

                ID = row.Cells[0].Value.ToString();


                string sql = @"SELECT SALES.Sales_Order_ID, SALES.Product_ID, SALES.Quantity_Sold, PRODUCT.Variant, PRODUCT.Product_Description " +
                             "FROM SALES " +
                             "LEFT JOIN ITEM " +
                             "ON SALES.Product_ID = PRODUCT.Product_ID " +
                             "WHERE SALES.Sales_Order_ID = '" + Convert.ToInt32(ID) + "'";

                try
                {
                    conn = new SqlConnection(connstring);
                    conn.Open();

                    comm = new SqlCommand(sql, conn);

                    adapt = new SqlDataAdapter();
                    ds = new DataSet();

                    adapt.SelectCommand = comm;
                    adapt.Fill(ds, "Data");

                    dataGridView1.DataMember = "Data";
                    dataGridView1.DataSource = ds;

                    conn.Close();

                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox9.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox13.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            comboBox4.SelectedItem = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            textBox12.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from CUSTOMER WHERE Customer_Name LIKE'%" + txtSearchCustomer.Text + "%' OR Customer_Surname LIKE'%" + txtSearchCustomer.Text + "%'";
            conn = new SqlConnection(connstring);
            conn.Close();
            conn.Open();

            comm = new SqlCommand(sql, conn);
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            adapt.SelectCommand = comm;
            adapt.Fill(ds,"Data");

            dataGridView2.DataMember = "Data";
            dataGridView2.DataSource = ds;

            conn.Close();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * from PRODUCT WHERE Customer_Name LIKE'%" + txtSearchCustomer.Text + "%'";
            conn = new SqlConnection(connstring);
            conn.Close();
            conn.Open();

            comm = new SqlCommand(sql, conn);
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "Data");

            dataGridView4.DataMember = "Data";
            dataGridView4.DataSource = ds;

            conn.Close();
        }
    }
}
