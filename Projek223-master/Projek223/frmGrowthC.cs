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
    public partial class frmGrowthC : Form
    {
        public frmGrowthC()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Baas\Documents\_TWEEDEJAAR\Projek 223\Projek223-master\Projek223\MicroGreensDatabase1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataReader lees;
        SqlCommand command;
        DataSet ds;
        SqlDataAdapter adapt;
        string ID="";

        private void addGC()                                                                                                         // ADD GROWTH CYCLE
        {
            errorProvider1.SetError(txtADD, "");
            if(cmbVarADD.SelectedItem != null)
            {
                if (int.TryParse(txtADD.Text, out int quantity))
                {
                    try
                    {
                        string sql3 = "SELECT * FROM SEED_VARIANT WHERE Description = '" + cmbVarADD.SelectedItem + "'";
                        int plusDays = 0;
                        int variant = 0;

                        con.Open();

                        command = new SqlCommand(sql3, con);
                        lees = command.ExecuteReader();
                        while (lees.Read())
                        {
                            plusDays = lees.GetInt32(1);
                            variant = lees.GetInt32(0);
                        }
                        lees.Close();

                        var dag = dateTimePickerADD.Value.AddDays(plusDays).ToShortDateString();
                        string sql2 = $"INSERT INTO VARIANT_GROWTH_CYCLE Values(@Variant,@Quantity,@Harvest_Date)";

                        command = new SqlCommand(sql2, con);
                        command.Parameters.AddWithValue("@Variant", variant);
                        command.Parameters.AddWithValue("@Quantity", txtADD.Text);
                        command.Parameters.AddWithValue("@Harvest_Date", dag);

                        command.ExecuteNonQuery();
                        con.Close();

                        loadGC();
                        MessageBox.Show("Successfully inserted!");
                        cmbVarADD.SelectedIndex = -1;
                        txtADD.Text = "";
                        dateTimePickerADD.Value = DateTime.Now;
                    }
                    catch (SqlException)
                    {
                    MessageBox.Show("Record not found!");
                    }
            }
                else
                {
                    errorProvider1.SetError(txtADD, "Enter valid integer for value!");
                    txtADD.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(cmbVarADD, "Select a variant!");
                cmbVarADD.Focus();
            }
        
        }

        private void changeGC()                                                                                                       // CHANGE GROWTH CYCLE
        {
            errorProvider1.SetError(txtCD, "");
            errorProvider1.SetError(cmbVarCD, "");

            if (ID != "")
            {
                if (int.TryParse(txtCD.Text, out int quantity))
                {
                    try
                    {
                        string sql3 = "SELECT Variant FROM SEED_VARIANT WHERE Description = '" + cmbVarCD.SelectedItem + "'";
                        int variant = 0;

                        con.Open();

                        command = new SqlCommand(sql3, con);
                        lees = command.ExecuteReader();
                        while (lees.Read())
                        {
                            variant = lees.GetInt32(0);
                        }
                        lees.Close();

                        var dag = dateTimePickerCD.Value.ToShortDateString();
                        string sql2 = $"UPDATE VARIANT_GROWTH_CYCLE SET Variant = @Variant, Quantity = @Quantity, Harvest_Date = @Harvest_Date WHERE Growth_Cycle_Id = '" + int.Parse(ID) + "'";

                        command = new SqlCommand(sql2, con);
                        command.Parameters.AddWithValue("@Variant", variant);
                        command.Parameters.AddWithValue("@Quantity", txtCD.Text);
                        command.Parameters.AddWithValue("@Harvest_Date", dag);

                        command.ExecuteNonQuery();
                        con.Close();

                        loadGC();
                        MessageBox.Show("Successfully changed!");
                        cmbVarCD.SelectedIndex = -1;
                        txtCD.Text = "";
                        dateTimePickerCD.Value = DateTime.Now;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Record not found!");
                    }

                }
                else
                {
                    errorProvider1.SetError(txtCD, "Enter valid integer for value!");
                    txtCD.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(cmbVarCD, "Select record in the datagrid!");
                cmbVarCD.Focus();
            }
        }

        private void deleteGC()                                                                                                         // DELETE GROWTH CYCLE
        {
            string delete = @"DELETE FROM VARIANT_GROWTH_CYCLE WHERE Growth_Cycle_Id = '" + int.Parse(ID) + "'";
            try
            {
                command = new SqlCommand(delete, con);
                con.Open();
                adapt = new SqlDataAdapter();
                adapt.DeleteCommand = command;
                adapt.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully deleted!");
                con.Close();
                cmbVarCD.SelectedIndex = -1;
                txtCD.Text = "";
                dateTimePickerCD.Value = DateTime.Now;
            }
            catch (SqlException)
            {
                MessageBox.Show("Record not found!");
            }


            loadGC();
        }

        private void harvest()                                                                                                                      // HARVEST
        {
            lblDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string sql = @"SELECT SEED_VARIANT.Description " +
                "FROM SEED_VARIANT JOIN VARIANT_GROWTH_CYCLE " +
                "ON SEED_VARIANT.Variant = VARIANT_GROWTH_CYCLE.Variant "+
                "WHERE VARIANT_GROWTH_CYCLE.Harvest_Date = CONVERT(datetime, '"+monthCalendar1.SelectionRange.Start.ToShortDateString()+"')";

            try
            {
                listBox1.Items.Clear();
                con = new SqlConnection(constr);
                command = new SqlCommand(sql, con);
                con.Open();

                lees = command.ExecuteReader();
                while (lees.Read())
                {
                    listBox1.Items.Add(lees.GetValue(0));
                }
                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void loadGC()                                                                                                                // LOAD GROWTH CYCLES
        {
            string sql = @"SELECT VARIANT_GROWTH_CYCLE.GROWTH_CYCLE_ID, VARIANT_GROWTH_CYCLE.Variant, VARIANT_GROWTH_CYCLE.Quantity, VARIANT_GROWTH_CYCLE.Harvest_Date, SEED_VARIANT.Description " +
                "FROM VARIANT_GROWTH_CYCLE "+
                "LEFT JOIN SEED_VARIANT " +
                "ON VARIANT_GROWTH_CYCLE.Variant = SEED_VARIANT.Variant ";
            string sql2 = @"SELECT Description FROM SEED_VARIANT";
            try
            {
                con = new SqlConnection(constr);
                command = new SqlCommand(sql, con);
                SqlCommand command2 = new SqlCommand(sql2, con);
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();

                adapt.SelectCommand = command;
                adapt.Fill(ds, "Info");

                dgGROWT.DataMember = "Info";
                dgGROWT.DataSource = ds;

                lees = command2.ExecuteReader();
                while (lees.Read())
                {
                    if (!cmbVarCD.Items.Contains(lees.GetValue(0)))
                    {
                        cmbVarADD.Items.Add(lees.GetValue(0));
                        cmbVarCD.Items.Add(lees.GetValue(0));
                    }        
                }

                con.Close();

            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void changeVariant()                                                                                                       // CHANGE VARIANT
        {
            errorProvider1.SetError(txtDaysCD, "");
            errorProvider1.SetError(txtTypeCD, "");
            errorProvider1.SetError(txtID, "");

            if (txtID.Text != "")
            {
                if (txtTypeCD.Text != "")
                {
                    if (int.TryParse(txtDaysCD.Text, out int daays))
                    {
                        try
                        {
                            con.Open();

                            string sql = $"UPDATE SEED_VARIANT SET Day_To_Harvest = @days, Description = @Desc WHERE Variant = '" + txtID.Text + "'";

                            command = new SqlCommand(sql, con);
                            command.Parameters.AddWithValue("@days", txtDaysCD.Text);
                            command.Parameters.AddWithValue("@Desc", txtTypeCD.Text);

                            command.ExecuteNonQuery();
                            con.Close();

                            loadVariant();
                            MessageBox.Show("Successfully changed!");
                            txtID.Text = "";
                            txtDaysCD.Text = "";
                            txtTypeCD.Text = "";
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtDaysCD, "Enter valid integer for value!");
                        txtDaysCD.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtTypeCD, "Enter a description!");
                    txtTypeCD.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtID, "Choose a record!");
                txtID.Focus();
            }
        }

        private void loadVariant()                                                                                                      // LOAD VARIANT
        {
            try
            {
                string sql = @"SELECT * FROM SEED_VARIANT";
                con = new SqlConnection(constr);
                command = new SqlCommand(sql, con);
                adapt = new SqlDataAdapter();
                ds = new DataSet();
                con.Open();

                adapt.SelectCommand = command;
                adapt.Fill(ds, "Info");

                datagridVariante.DataMember = "Info";
                datagridVariante.DataSource = ds;

                con.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void addVariant()                                                                                                          // ADD VARIANT
        {
            errorProvider1.SetError(txtDaysADD, "");
            errorProvider1.SetError(txtTypeADD, "");

            if(txtTypeADD.Text != "")
            {
                if (int.TryParse(txtDaysADD.Text, out int daays))
                {
                    try
                    { 
                        con.Open();

                        string sql = $"INSERT INTO SEED_VARIANT Values(@Days,@Variant)";

                        command = new SqlCommand(sql, con);
                        command.Parameters.AddWithValue("@Days", txtDaysADD.Text);
                        command.Parameters.AddWithValue("@Variant", txtTypeADD.Text);

                        command.ExecuteNonQuery();
                        con.Close();

                        loadVariant();
                        MessageBox.Show("Successfully inserted!");
                        txtADD.Text = "";
                        txtDaysADD.Text = "";
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Record not found!");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtDaysADD, "Enter valid integer for value!");
                    txtDaysADD.Focus();
                }
            }
            else
            {
                errorProvider1.SetError(txtTypeADD, "Enter description!");
                txtTypeADD.Focus();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            harvest();
        }

        private void frmGrowthC_Load(object sender, EventArgs e)
        {
            harvest();
            loadGC();
            loadVariant();
        }

        private void dgGROWT_CellClick(object sender, DataGridViewCellEventArgs e)                                                   // CHOOSE DATAGRID ROW GROWTH CYCLES
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = dgGROWT.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtCD.Text = row.Cells[2].Value.ToString();
                cmbVarCD.SelectedItem = row.Cells[4].Value.ToString();
                dateTimePickerCD.Text = row.Cells[3].Value.ToString();
                ID = row.Cells[0].Value.ToString();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            addGC();
        }

        private void lblBTNAddGC_Click(object sender, EventArgs e)
        {
            addGC();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            changeGC();
        }

        private void lblChangeGC_Click(object sender, EventArgs e)
        {
            changeGC();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            deleteGC();
        }

        private void lblDeleteGC_Click(object sender, EventArgs e)
        {
            deleteGC();
        }

        private void dgVariants_CellClick(object sender, DataGridViewCellEventArgs o)                                                       // CHOOSE DATAGRID ROW VARIANTS
        {
            if (o.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row2 = datagridVariante.Rows[o.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtID.Text = row2.Cells[0].Value.ToString();
                txtDaysCD.Text = row2.Cells[1].Value.ToString();
                txtTypeCD.Text = row2.Cells[2].Value.ToString();
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            addVariant();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            addVariant();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            changeVariant();
        }

        private void lblChangeVar_Click(object sender, EventArgs e)
        {
            changeVariant();
        }

        private void cmbVarADD_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbVarADD,"");
        }

        private void cmbVarCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cmbVarCD, "");
        }

        private void txtSearchVar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * from SEED_VARIANT WHERE Description LIKE'%" + txtSearchVar.Text + "%'";
                con = new SqlConnection(constr);
                con.Open();

                command = new SqlCommand(sql, con);
                adapt = new SqlDataAdapter();
                ds = new DataSet();

                adapt.SelectCommand = command;
                adapt.Fill(ds, "Info");

                datagridVariante.DataMember = "Info";
                datagridVariante.DataSource = ds;

                con.Close();
            }
            catch (SqlException er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
