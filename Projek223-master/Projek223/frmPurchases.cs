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
    public partial class frmPurchases : Form
    {
        public frmPurchases()
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
        int Purchase_ID = 0;

        //Reload datagridviews after changes
        public void RefreshPurchase()
        {
            try
            {
               // string sql = @"SELECT * FROM PURCHASE_INVOICE";

                string sql = @"SELECT PURCHASE_INVOICE.Purchase_Order_ID, PURCHASE_INVOICE.Purchase_Order_Date, SUPPLIER.Supplier_Name, PURCHASE_INVOICE.Total_Cost " +
                             "FROM PURCHASE_INVOICE " +
                             "LEFT JOIN SUPPLIER " +
                             "ON PURCHASE_INVOICE.Supplier_ID = SUPPLIER.Supplier_ID ";
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

        public void RefreshSupplier()
        {
            try
            {
                string sql = @"SELECT * FROM SUPPLIER";
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

        public void RefreshItem()
        {
            try
            {
                string sql = @"SELECT * FROM ITEM";
                conn = new SqlConnection(connstring);
                conn.Open();

                comm = new SqlCommand(sql, conn);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Data");

                dataGridView3.DataMember = "Data";
                dataGridView3.DataSource = ds;

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Records not found");
            }

        }

        private void addPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            textBox6.Enabled = false;

            //New Purchase
            //Fill supplier combobox
            try
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string sqlSupplier = @"SELECT * FROM SUPPLIER";

                comm = new SqlCommand(sqlSupplier, conn);

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
                MessageBox.Show("Could not fill supplier combobox");
            }

            //Fill item combobox
            //Load item and desc combobox
            try
            {
                conn.Open();
                string sqlItem = @"SELECT * FROM ITEM";

                comm = new SqlCommand(sqlItem, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    if (!comboBox2.Items.Contains(read.GetValue(2)))
                    {
                        comboBox2.Items.Add(read.GetValue(2));
                    }
                    if (!comboBox3.Items.Contains(read.GetValue(1)))
                    {
                        comboBox3.Items.Add(read.GetValue(1));
                    }

                }

                conn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Item combobox.");
            }

            //Load datagridview
            try
            {
                RefreshPurchase();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Purchase datagridview.");
            }

            //Suppliers
            //Fill Datagridview 
            try
            {
                RefreshSupplier();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not load Supplier datagridview.");
            }

            //Fill suppliers combobox
            try
            {
                conn.Open();
                string sqlSupplier = @"SELECT * FROM SUPPLIER";

                comm = new SqlCommand(sqlSupplier, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    if (!comboBox4.Items.Contains(read.GetValue(1)))
                    {
                        comboBox4.Items.Add(read.GetValue(1));
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not insert suppliers into combobox");
            }

            //Item
            //Load Datagridview
            try
            {
                RefreshItem();

            }
            catch (Exception)
            {
                MessageBox.Show("Could not load Supplier datagridview.");
            }

        }

        //Fill Add New Purchase Listbox
        public void FillListbox()
        {
            errorProvider1.SetError(comboBox2, "");
            errorProvider1.SetError(comboBox3, "");
            errorProvider1.SetError(textBox6, "");

            if (comboBox2.SelectedItem != null)
            {
                if (comboBox3.SelectedItem != null)
                {
                    if (int.TryParse(textBox6.Text, out int quantity))
                    {
                        try
                        {
                            string item = comboBox2.SelectedItem.ToString();
                            listBox1.Items.Add(item + "       " + quantity);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Could not fill listbox with inserted data.");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox6, "Enter a valid integer for quantity.");
                        textBox6.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox3, "Select a description.");
                    comboBox3.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(comboBox2, "Select a item.");
                comboBox2.Focus();
            }

        }

        //Add Purchase Invoice
        private void AddNewPurchaseSupplier()
        {
            errorProvider1.SetError(comboBox1, "");
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    string supplier_id = @"SELECT * FROM SUPPLIER WHERE Supplier_Name =  '" + comboBox1.Text + "'";
                    int supplier = 0;

                    conn.Open();

                    comm = new SqlCommand(supplier_id, conn);
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        supplier = read.GetInt32(0);
                    }
                    read.Close();
                    conn.Close();

                    conn.Open();

                    var date = dateTimePicker1.Value.ToShortDateString();

                    string total_cost = total.ToString();

                    string addInvoice = @"INSERT INTO PURCHASE_INVOICE VALUES(@date, @supplier, @total) ; SELECT SCOPE_IDENTITY()";


                    comm = new SqlCommand(addInvoice, conn);

                    comm.Parameters.AddWithValue("@date", date);
                    comm.Parameters.AddWithValue("@supplier", supplier);
                    comm.Parameters.AddWithValue("@total", total);

                    Purchase_ID = Convert.ToInt32(comm.ExecuteScalar());

                    conn.Close();

                    MessageBox.Show("Purchase invoice successfully created.");

                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    textBox6.Enabled = true;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Could not add supplier to new purchase.");
                }
            }
            else
            {
                errorProvider1.SetError(comboBox1, "Select a supplier.");
                comboBox1.Focus();
            }
        }

        //Add Purchase Order 
        public void AddNewPurchaseItem()
        {
            errorProvider1.SetError(comboBox2, "");
            errorProvider1.SetError(comboBox3, "");
            errorProvider1.SetError(textBox6, "");

            if (comboBox2.SelectedItem != null)
            {
                if (comboBox3.SelectedItem != null)
                {
                    if (int.TryParse(textBox6.Text, out int quantity))
                    {
                        try
                        {
                            string item_id = @"SELECT * FROM ITEM WHERE Item = '" + comboBox2.Text + "'";
                            int item = 0;
                            decimal price = 0;


                            conn.Open();

                            comm = new SqlCommand(item_id, conn);
                            read = comm.ExecuteReader();
                            while (read.Read())
                            {
                                item = read.GetInt32(0);
                                price = read.GetDecimal(3);
                            }
                            read.Close();

                            total = price * quantity;

                            string addOrder = @"INSERT INTO PURCHASE_ORDER VALUES(@id, @item,@quantity)";

                            comm = new SqlCommand(addOrder, conn);

                            comm.Parameters.AddWithValue("@ID", Purchase_ID);
                            comm.Parameters.AddWithValue("@item", item);
                            comm.Parameters.AddWithValue("@quantity", quantity);

                            comm.ExecuteNonQuery();

                            conn.Close();


                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;
                            textBox6.Text = "";

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Could not add item.");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(textBox6, "Enter a valid integer for quantity.");
                        textBox6.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(comboBox3, "Select a description.");
                    comboBox3.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(comboBox2, "Select a item.");
                comboBox2.Focus();
            }

        }

        //Change Purchase Invoice
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
                            string supplier_id = @"SELECT * FROM SUPPLIER WHERE Supplier_Name = '" + comboBox4.Text + "'";
                            int supplier = 0;

                            conn.Open();

                            comm = new SqlCommand(supplier_id, conn);
                            read = comm.ExecuteReader();
                            while (read.Read())
                            {
                                supplier = read.GetInt32(0);
                            }
                            read.Close();


                            string date = dateTimePicker3.Value.ToShortDateString();


                            string changeOrder = @"UPDATE PURCHASE_INVOICE SET Purchase_Order_Date = @date, Supplier_ID = @id, Total_Cost = @cost WHERE PURCHASE_ORDER_ID = '" + int.Parse(textBox12.Text) + "'";

                            comm = new SqlCommand(changeOrder, conn);

                            comm.Parameters.AddWithValue("@date", date);
                            comm.Parameters.AddWithValue("@id", supplier);
                            comm.Parameters.AddWithValue("@cost", total);

                            comm.ExecuteNonQuery();

                            RefreshPurchase();

                            textBox12.Text = "";
                            comboBox4.SelectedIndex = -1;
                            textBox13.Text = "";

                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Could not change purchase invoice");
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
                    errorProvider1.SetError(comboBox4, "Select a supplier to change.");
                    comboBox4.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox12, "Select an record to change.");
                textBox12.Focus();
            }
        }

        //Change Purchase Order
        public void ChangeInvoiceItem()
        {
            errorProvider1.SetError(comboBox5, "");
            errorProvider1.SetError(textBox5, "");

            if (comboBox5.Text != "")
            {
                if (int.TryParse(textBox5.Text, out int quantity))
                {
                    try
                    {
                        string item_id = @"SELECT * FROM ITEM WHERE Item = '" + comboBox5.Text + "'";

                        int item = 0;

                        conn.Open();

                        comm = new SqlCommand(item_id, conn);

                        read = comm.ExecuteReader();
                        while (read.Read())
                        {
                            item = read.GetInt32(0);
                        }
                        read.Close();

                        string changeOrder = @"UPDATE PURCHASE_ORDER SET Item_ID = @item, Quantity_Bought = @quantity WHERE PURCHASE_ORDER_ID = '" + int.Parse(textBox12.Text) + "'";

                        comm = new SqlCommand(changeOrder, conn);

                        comm.Parameters.AddWithValue("item", item);
                        comm.Parameters.AddWithValue("@quantity", quantity);

                        comm.ExecuteNonQuery();

                        conn.Close();

                        comboBox5.Text = "";
                        textBox5.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Could not change purchase invoice");
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
                errorProvider1.SetError(comboBox5, "Enter a item");
                comboBox5.Focus();
            }
        }

        //Add Supplier
        public void AddSupplier()
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox1, "");

            if (textBox1.Text != "")
            {
                if (maskedTextBox1.Text != "")
                {
                    if (maskedTextBox2.Text != "")
                    {
                        try
                        {
                            conn.Open();

                            string name = textBox1.Text;
                            string cell = maskedTextBox1.Text;
                            string email = maskedTextBox2.Text;

                            string SqlInsertSupplier = @"INSERT INTO SUPPLIER VALUES(@Name, @Cell, @Email)";

                            comm = new SqlCommand(SqlInsertSupplier, conn);

                            comm.Parameters.AddWithValue("@Name", name);
                            comm.Parameters.AddWithValue("@Cell", cell);
                            comm.Parameters.AddWithValue("@Email", email);

                            comm.ExecuteNonQuery();

                            RefreshSupplier();

                            MessageBox.Show("Supplier successfully added.");
                            conn.Close();
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "Could not add Supplier");
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
                    errorProvider1.SetError(maskedTextBox1, "Enter supplier contact number.");
                    maskedTextBox1.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Enter a supllier name.");
                textBox1.Focus();
            }
        }

        //Change Supplier
        public void ChangeSupplier()
        {
            errorProvider1.SetError(textBox2, "");
            errorProvider1.SetError(textBox3, "");
            errorProvider1.SetError(maskedTextBox3, "");
            errorProvider1.SetError(maskedTextBox4, "");

            ID = textBox2.Text;
            if (ID != null)
            {
                if (textBox3.Text != "")
                {
                    if (maskedTextBox3.Text != "")
                    {
                        if (maskedTextBox4.Text != "")
                        {
                            try
                            {
                                conn.Open();

                                string name = textBox3.Text;
                                string cell = maskedTextBox3.Text;
                                string email = maskedTextBox4.Text;

                                string changeSupplier = @"UPDATE SUPPLIER SET Supplier_Name = @name, Supplier_Number = @cell, Supplier_Email = @email WHERE Supplier_ID = '" + int.Parse(textBox2.Text) + "'";

                                comm = new SqlCommand(changeSupplier, conn);

                                comm.Parameters.AddWithValue("@name", name);
                                comm.Parameters.AddWithValue("@cell", cell);
                                comm.Parameters.AddWithValue("@email", email);

                                comm.ExecuteNonQuery();
                                RefreshSupplier();

                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Could not change supplier");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(maskedTextBox4, "Enter a supplier contact number.");
                            maskedTextBox4.Focus();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(maskedTextBox3, "Enter a supplier contact number.");
                        maskedTextBox3.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox3, "Enter a supplier name to change.");
                    textBox3.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox2, "Select a record to change.");
                textBox2.Focus();
            }

        }

        //Add Item
        public void AddItem()
        {
            errorProvider1.SetError(textBox9, "");
            errorProvider1.SetError(maskedTextBox7, "");
            errorProvider1.SetError(maskedTextBox8, "");

            if (textBox9.Text != "")
            {
                if (maskedTextBox7.Text != "")
                {
                    if (double.TryParse(maskedTextBox8.Text, out double price))
                    {
                        try
                        {
                            conn.Open();

                            string item = textBox9.Text;
                            string desc = maskedTextBox7.Text;

                            string SqlInsertSupplier = @"INSERT INTO ITEM VALUES(@Desc, @Item, @Price)";

                            comm = new SqlCommand(SqlInsertSupplier, conn);

                            comm.Parameters.AddWithValue("@Desc", desc);
                            comm.Parameters.AddWithValue("@Item", item);
                            comm.Parameters.AddWithValue("@Price", price);

                            comm.ExecuteNonQuery();

                            RefreshItem();

                            MessageBox.Show("Item successfully added.");
                            conn.Close();
                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message, "Could not add Supplier");
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
                errorProvider1.SetError(textBox9, "Enter a item.");
                textBox9.Focus();
            }
        }

        //Change Item
        public void ChangeItem()
        {
            errorProvider1.SetError(textBox7, "");
            errorProvider1.SetError(textBox8, "");
            errorProvider1.SetError(textBox10, "");
            errorProvider1.SetError(textBox11, "");

            ID = textBox7.Text;
            if (ID != null)
            {
                if (textBox8.Text != "")
                {
                    if (textBox10.Text != "")
                    {
                        if (double.TryParse(textBox11.Text, out double price))
                        {
                            try
                            {
                                string item_id = @"SELECT Item FROM ITEM WHERE ITEM_ID = '" + comboBox5.Text + "'";

                                int itemID = 0;

                                conn.Open();

                                comm = new SqlCommand(item_id, conn);
                                read = comm.ExecuteReader();
                                while (read.Read())
                                {
                                    itemID = read.GetInt32(0);
                                }
                                read.Close();


                                string desc = textBox10.Text;
                                string item = textBox8.Text;

                                string deleteItem = @"UPDATE ITEM SET Item_Description = @desc, Item = @item, Item_Price = @price WHERE Item_ID = '" + int.Parse(textBox7.Text) + "'";

                                comm = new SqlCommand(deleteItem, conn);

                                comm.Parameters.AddWithValue("@desc", desc);
                                comm.Parameters.AddWithValue("@item", item);
                                comm.Parameters.AddWithValue("@price", price);

                                comm.ExecuteNonQuery();
                                RefreshItem();

                                conn.Close();

                                textBox10.Text = "";
                                textBox7.Text = "";
                                textBox11.Text = "";
                                textBox8.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Could not change item");
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
                        errorProvider1.SetError(textBox10, "Enter description to change.");
                        textBox10.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox8, "Enter item to change.");
                    textBox8.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(textBox7, "Select a record to change.");
                textBox7.Focus();
            }
        }

        //Buttons and Click events
        private void label30_Click(object sender, EventArgs e)
        {
            AddNewPurchaseSupplier();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            AddNewPurchaseSupplier();
        }

        private void lblBTNAddGC_Click(object sender, EventArgs e)
        {
            FillListbox();
            AddNewPurchaseItem();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FillListbox();
            AddNewPurchaseItem();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            textBox6.Enabled = false;

            MessageBox.Show("Purchase invoice successfully inserted");

            string supplier_id = @"SELECT * FROM SUPPLIER WHERE Supplier_Name =  '" + comboBox1.Text + "'";
            int supplier = 0;

            conn.Open();

            comm = new SqlCommand(supplier_id, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                supplier = read.GetInt32(0);
            }
            read.Close();


            string sql = @"UPDATE PURCHASE_INVOICE SET Total_Cost = @cost WHERE Purchase_Order_ID = '" + Purchase_ID + "'";

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
            textBox6.Enabled = false;

            MessageBox.Show("Purchase invoice successfully inserted");

            string supplier_id = @"SELECT * FROM SUPPLIER WHERE Supplier_Name =  '" + comboBox1.Text + "'";
            int supplier = 0;

            conn.Open();

            comm = new SqlCommand(supplier_id, conn);
            read = comm.ExecuteReader();

            while (read.Read())
            {
                supplier = read.GetInt32(0);
            }
            read.Close();


            string sql = @"UPDATE PURCHASE_INVOICE SET Purchase_Order_ID = @PurchaseID, Purchase_Order_Date = @date, Supplier_ID = @supplier, Total_Cost = @cost WHERE Purchase_Oder_ID = '" + Purchase_ID + "'";

            comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@Purchase_ID", Purchase_ID);
            comm.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
            comm.Parameters.AddWithValue("@supplier", supplier);
            comm.Parameters.AddWithValue("@cost", total);

            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            ChangeInvoice();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            ChangeInvoice();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            ChangeInvoiceItem();
            dataGridView1.ClearSelection();
            MessageBox.Show("Invoice successfully changed. Click on Change Invoice to change more data.");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ChangeInvoiceItem();
            dataGridView1.ClearSelection();
            MessageBox.Show("Invoice successfully changed. Click on Change Invoice to change more data.");
        }

        private void label18_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ChangeSupplier();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ChangeSupplier();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            ChangeItem();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ChangeItem();
        }

        //Fill textboxes with datagridview records
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs dg4)
        {
            if (dg4.RowIndex >= 0)
            {
                textBox12.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
                dateTimePicker3.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
                textBox13.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
                comboBox4.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();

                DataGridViewRow row = dataGridView4.Rows[dg4.RowIndex];

                ID = row.Cells[0].Value.ToString();


                string sql = @"SELECT PURCHASE_ORDER.Purchase_Order_ID, PURCHASE_ORDER.Item_ID, PURCHASE_ORDER.Quantity_Bought, ITEM.Item, ITEM.Item_Description " +
                             "FROM PURCHASE_ORDER " +
                             "LEFT JOIN ITEM " +
                             "ON PURCHASE_ORDER.Item_ID = ITEM.Item_ID " +
                             "WHERE PURCHASE_ORDER.Purchase_Order_ID = '" + Convert.ToInt32(ID) + "'";   

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

                    string sql2 = @"SELECT Item_Description FROM ITEM WHERE Item = '" + comboBox5.Text + "'";
                    conn = new SqlConnection(connstring);
                    conn.Open();

                    comm = new SqlCommand(sql2, conn);

                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        if (!comboBox6.Items.Contains(read.GetValue(0)))
                        {
                            comboBox6.Items.Add(read.GetValue(0));
                        }
                    }

                    conn.Close();

                }
                catch (SqlException er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                string sql = @"SELECT Item_Description FROM ITEM WHERE Item = '"+ comboBox5.Text + "'";
                conn = new SqlConnection(connstring);
                conn.Open();

                comm = new SqlCommand(sql, conn);

                read = comm.ExecuteReader();

                while (read.Read())
                {
                    if (!comboBox6.Items.Contains(read.GetValue(0)))
                    {
                        comboBox6.Items.Add(read.GetValue(0));
                    }
                }

                conn.Close();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}


