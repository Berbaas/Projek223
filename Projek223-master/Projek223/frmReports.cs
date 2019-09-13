using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Reflection;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Projek223
{
    public partial class frmReports : Form
    {
        bool IsValid = true;
        public SqlConnection conn;
        public SqlCommand comm;
        public DataSet ds;
        public DataView dv;
        public SqlDataAdapter adapt;
        public string folderPath;
        private string sName, sFrom, sWhere;
        public string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Baas\Documents\_TWEEDEJAAR\Projek 223\Projek223-master\Projek223\MicroGreensDatabase1.mdf;Integrated Security=True";


        public frmReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            //loadGrid();

            sName = "Sales ";
            sFrom = "[SALES_INVOICE] WHERE Sales_Order_Date";
            sWhere = "Sales_Order_Date";

            DateTime date;

            if (rbWeek.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if (rbWeeks.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if (rbMonth.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if (rbMonths.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if (rbYear.Checked)
            {
                date = DateTime.Today.AddDays(-366);
            }
            else
            {
                date = DateTime.Today.AddDays(-366);
            }

            sName += "Report - From " + date.ToString("dd/MM/yyyy") + " To " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            sFrom += " > " + date.ToString("dd/MM/yyyy") + " and " + sWhere + " < " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            

            try
            {
               
                conn = new SqlConnection(connectionstring);

                conn.Open();

                SqlCommand comm;
                string sql;
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                sql = @"SELECT * from SALES_INVOICE";
                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Sales");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Sales";

                conn.Close();

            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //loadGrid();

            sName = "Purchases ";
            sFrom = "[PURCHASE_INVOICE] WHERE Purchase_Order_Date";
            sWhere = "Purchase_Order_Date";

            DateTime date;

            if (rbWeek.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if (rbWeeks.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if (rbMonth.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if (rbMonths.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if (rbYear.Checked)
            {
                date = DateTime.Today.AddDays(-366);
            }
            else
            {
                date = DateTime.Today.AddDays(-366);
            }

            sName += "Report - From " + date.ToString("dd/MM/yyyy") + " To " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            sFrom += " > " + date.ToString("dd/MM/yyyy") + " and " + sWhere + " < " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            

            try
            {
                
                conn = new SqlConnection(connectionstring);

                conn.Open();

                SqlCommand comm;
                string sql;
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                sql = @"SELECT * from PURCHASE_INVOICE";
                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "Purchase");

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "Purchase";

                conn.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Please enter your email.");
                }
                else
                {
                    errorProvider1.Dispose();
                }

                //SaveFileDialog saveF = new SaveFileDialog();
                //saveF.FileName = sName;

                if (dataGridView1.RowCount != 0)
                {
                    //if (saveF.ShowDialog() == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        PdfPTable pdfPTable = new PdfPTable(dataGridView1.ColumnCount);
                        pdfPTable.DefaultCell.Padding = 3;
                        pdfPTable.WidthPercentage = 30;
                        pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        pdfPTable.DefaultCell.BorderWidth = 1;

                        //folderPath = saveF.FileName;

                        if (!folderPath.Contains(".pdf"))
                        {
                            folderPath += ".pdf";
                        }

                        foreach(DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            pdfPTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                try
                                {
                                    pdfPTable.AddCell(cell.Value.ToString());
                                }
                                catch { }
                            }
                        }

                        using (FileStream stream = new FileStream(folderPath, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(new Paragraph("\nReport: " + sName + "\n\n"));
                            pdfDoc.Add(pdfPTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        try
                        {
                            MailMessage mail = new MailMessage();
                            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("noreply.saladconfetti@gmail.com");
                            mail.To.Add(textBox1.Text);
                            mail.Subject = "Salad Confetti" + sName;
                            mail.Body = "Attached is a report" + sName;

                            System.Net.Mail.Attachment attachment;
                            attachment = new System.Net.Mail.Attachment(folderPath);
                            mail.Attachments.Add(attachment);

                            SmtpServer.Port = 587;
                            SmtpServer.Credentials = new System.Net.NetworkCredential("noreply.saladconfetti@gmail.com", "SaladConfetti1234");
                            SmtpServer.EnableSsl = true;

                            SmtpServer.Send(mail);
                            MessageBox.Show("An email with the report has been sent to " + textBox1.Text);
                        }
                        catch (TimeoutException et)
                        {
                            MessageBox.Show(et.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        this.Cursor = Cursors.Arrow;
                    }
                }
                //else
                {
                    MessageBox.Show("There is no records matching the criteria to draw a report", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider2.SetError(textBox2, "Please enter your email.");
            }
            else
            {
                errorProvider2.Dispose();
            }

            SaveFileDialog saveF = new SaveFileDialog();
            saveF.FileName = sName;

            if (dataGridView2.RowCount != 0)
            {
                if (saveF.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    PdfPTable pdfPTable = new PdfPTable(dataGridView2.ColumnCount);
                    pdfPTable.DefaultCell.Padding = 3;
                    pdfPTable.WidthPercentage = 30;
                    pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfPTable.DefaultCell.BorderWidth = 1;

                    folderPath = saveF.FileName;

                    if (!folderPath.Contains(".pdf"))
                    {
                        folderPath += ".pdf";
                    }

                    foreach(DataGridViewColumn column in dataGridView2.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        pdfPTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            try
                            {
                                pdfPTable.AddCell(cell.Value.ToString());
                            }
                            catch { }
                        }
                    }

                    using (FileStream stream = new FileStream(folderPath, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(new Paragraph("\nReport: " + sName + "\n\n"));
                        pdfDoc.Add(pdfPTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("noreply.saladconfetti@gmail.com");
                        mail.To.Add(textBox2.Text);
                        mail.Subject = "Salad Confetti" + sName;
                        mail.Body = "Attached is a report" + sName;

                        System.Net.Mail.Attachment attachment;
                        attachment = new System.Net.Mail.Attachment(folderPath);
                        mail.Attachments.Add(attachment);

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("noreply.saladconfetti@gmail.com", "SaladConfetti1234");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                        MessageBox.Show("An email with the report has been sent to " + textBox2.Text);
                    }
                    catch (TimeoutException et)
                    {
                        MessageBox.Show(et.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.Cursor = Cursors.Arrow;
                }
            }
            else
            {
                MessageBox.Show("There is no records matching the criteria to draw a report", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*private void sendEmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("noreply.saladconfetti@gmail.com");
                mail.To.Add(textBox2.Text);
                mail.Subject = "Salad Confetti" + sName;
                mail.Body = "Attached is a report" + sName;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(folderPath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("noreply.saladconfetti@gmail.com", "SaladConfetti1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("An email with the report has been sent to " + getMail());
            }
            catch(TimeoutException et)
            {
                MessageBox.Show(et.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/


        /*public string getMail()
        {
            string email;
            email = textBox1.Text;
            email = textBox2.Text;
            return email;
        }*/

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            
          
            conn = new SqlConnection(connectionstring);

            conn.Open();

            SqlCommand comm;
            string sql;
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * from CUSTOMER";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "Customer");

            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "Customer";

            conn.Close();

            for(int i = 0; i < dataGridView3.Columns.Count; i++)
            {
                if(!comboBox1.Items.Contains(dataGridView3.Columns[i].HeaderText))
                {
                    comboBox1.Items.Add(dataGridView3.Columns[i].HeaderText);
                }
            }

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
     
            conn = new SqlConnection(connectionstring);

            conn.Open();

            SqlCommand comm;
            string sql;
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * from SUPPLIER";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "Supplier");

            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "Supplier";

            conn.Close();

            for (int i = 0; i < dataGridView4.Columns.Count; i++)
            {
                if (!comboBox2.Items.Contains(dataGridView4.Columns[i].HeaderText))
                {
                    comboBox2.Items.Add(dataGridView4.Columns[i].HeaderText);
                }
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionstring);

            conn.Open();

            SqlCommand comm;
            string sql;
            adapt = new SqlDataAdapter();
            ds = new DataSet();

            sql = @"SELECT * from PRODUCT";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "Product");

            dataGridView5.DataSource = ds;
            dataGridView5.DataMember = "Product";

            conn.Close();

            for (int i = 0; i < dataGridView5.Columns.Count; i++)
            {
                if (!comboBox3.Items.Contains(dataGridView5.Columns[i].HeaderText))
                {
                    comboBox3.Items.Add(dataGridView5.Columns[i].HeaderText);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortDGCustomer(comboBox1.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider3.SetError(textBox3, "Please enter your search word.");
            }
            else
            {
                errorProvider2.Dispose();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           conn = new SqlConnection(connectionstring);

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql;
            sql = "SELECT * from CUSTOMER WHERE Customer_ID LIKE '%" + textBox3.Text + "%'" + "OR Customer_Name LIKE '%" + textBox3.Text + "%'" + "OR Customer_Surname LIKE '%" + textBox3.Text + "%'" + "OR Cell_Number LIKE '%" + textBox3.Text + "%'" + "OR Customer_Email LIKE '%" + textBox3.Text + "%'";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "CustomerSearch");

            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "CustomerSearch";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionstring);

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql;
            sql = "SELECT * from Supplier WHERE Supplier_ID LIKE '%" + textBox4.Text + "%'" + "OR Supplier_Name LIKE '%" + textBox4.Text + "%'" + "OR Supplier_Number LIKE '%" + textBox4.Text + "%'" + "OR Supplier_Email LIKE '%" + textBox4.Text + "%'";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "SupplierSearch");

            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "SupplierSearch";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortDGSupplier(comboBox2.SelectedItem.ToString());
        }

        /*private void generateName()
        {
            
            if (tabControl1.SelectedTab == tabPage1)
            {
                sName = "Sales ";
                sFrom = "[SALES_INVOICE] WHERE Sales_Order_Date";
                sWhere = "Sales_Order_Date";
            }
            else
            {
                sName = "Purchases ";
                sFrom = "[PURCHASE_INVOICE] WHERE Purchase_Order_Date";
                sWhere = "Purchase_Order_Date";
            }
            

            DateTime date;

            if(rbWeek.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if(rbWeeks.Checked)
            {
                date = DateTime.Now.AddDays(-7);
            }
            else if(rbMonth.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if(rbMonths.Checked)
            {
                date = DateTime.Today.AddDays(-30);
            }
            else if(rbYear.Checked)
            {
                date = DateTime.Today.AddDays(-366);
            }
            else
            {
                date = DateTime.Today.AddDays(-366);
            }

            sName += "Report - From " + date.ToString("dd/MM/yyyy") + " To " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            sFrom += " > " + date.ToString("dd/MM/yyyy") + " and " + sWhere + " < " + DateTime.Today.Date.ToString("dd/MM/yyyy");

            loadGrid();
        }*/

        private void loadGrid()
        {
            /*if(tabControl1.SelectedTab == tabPage1)
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projek223-master\Projek223-master\Projek223\MicroGreensDatabase1.mdf;Integrated Security=True";
                conn = new SqlConnection(connectionstring);

                conn.Open();

                SqlCommand comm;
                string sql;
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                sql = @"SELECT * from " + sFrom;
                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "SourceTable");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SourceTable";

                conn.Close();
            }
            else if(tabControl1.SelectedTab == tabPage2)
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\Projek223-master\Projek223-master\Projek223\MicroGreensDatabase1.mdf;Integrated Security=True";
                conn = new SqlConnection(connectionstring);

                conn.Open();

                SqlCommand comm;
                string sql;
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                sql = @"SELECT * FROM " + sFrom;
                comm = new SqlCommand(sql, conn);

                adapt.SelectCommand = comm;
                adapt.Fill(ds, "SourceTable");

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "SourceTable";

                conn.Close();
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider4.SetError(textBox4, "Please enter your search word.");
            }
            else
            {
                errorProvider4.Dispose();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortDGProduct(comboBox3.SelectedItem.ToString());
        }

        public void sortDGCustomer(string value)
        {
            adapt = new SqlDataAdapter();
            comm = new SqlCommand();
            dv = new DataView();

            string sql;
            sql = @"SELECT * from Customer";
            comm = new SqlCommand(sql, conn);
            adapt.SelectCommand = comm;

            adapt.Fill(ds);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView3.DataSource = dv;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           conn = new SqlConnection(connectionstring);

            adapt = new SqlDataAdapter();
            ds = new DataSet();

            string sql;
            sql = "SELECT * from Product WHERE Product_ID LIKE '%" + textBox5.Text + "%'" + "OR Product_Description LIKE '%" + textBox5.Text + "%'" + "OR Variant LIKE '%" + textBox5.Text + "%'" + "OR Product_Price LIKE '%" + textBox5.Text + "%'";
            comm = new SqlCommand(sql, conn);

            adapt.SelectCommand = comm;
            adapt.Fill(ds, "SupplierSearch");

            dataGridView5.DataSource = ds;
            dataGridView5.DataMember = "SupplierSearch";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider5.SetError(textBox5, "Please enter your search word.");
            }
            else
            {
                errorProvider5.Dispose();
            }
        }

        public void sortDGSupplier(string value)
        {
            adapt = new SqlDataAdapter();
            comm = new SqlCommand();
            dv = new DataView();

            string sql;
            sql = @"SELECT * from SUPPLIER";
            comm = new SqlCommand(sql, conn);
            adapt.SelectCommand = comm;

            adapt.Fill(ds);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView4.DataSource = dv;
        }

        public void sortDGProduct(string value)
        {
            adapt = new SqlDataAdapter();
            comm = new SqlCommand();
            dv = new DataView();

            string sql;
            sql = @"SELECT * from Product";
            comm = new SqlCommand(sql, conn);
            adapt.SelectCommand = comm;

            adapt.Fill(ds);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView5.DataSource = dv;
        }
    }
}
