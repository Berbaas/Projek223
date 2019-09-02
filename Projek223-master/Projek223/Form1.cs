using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek223
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(55, 60, 64);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(55, 60, 64);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(50, 168, 168); 
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(55, 60, 64);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(50, 168, 168);
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(55, 60, 64);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblGrowth_Click(object sender, EventArgs e)        // GROWTH label click
        {
            frmGrowthC GC = new frmGrowthC();
            GC.TopLevel = false;
            GC.Parent = pnlFORMS;
            GC.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 123, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);

        }

        private void pnlGrowth_Click(object sender, EventArgs e)        // GROWTH label click   
        {
            frmGrowthC GC = new frmGrowthC();
            GC.TopLevel = false;
            GC.Parent = pnlFORMS;
            GC.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 123, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);
        }

        private void pnlSales_Click(object sender, EventArgs e)        // SALES panel click  
        {
            frmSales Sales = new frmSales();
            Sales.TopLevel = false;
            Sales.Parent = pnlFORMS;
            Sales.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 123, 168);
        }

        private void lblSales_Click(object sender, EventArgs e)        // SALES label click  
        {
            frmSales Sales = new frmSales();
            Sales.TopLevel = false;
            Sales.Parent = pnlFORMS;
            Sales.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 123, 168);
        }

        private void pnlPurchases_Click(object sender, EventArgs e)        // PURCHASES panel click  
        {
            frmPurchases Purch = new frmPurchases();
            Purch.TopLevel = false;
            Purch.Parent = pnlFORMS;
            Purch.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 123, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);
        }

        private void lblPurchases_Click(object sender, EventArgs e)        // PURCHASES label click  
        {
            frmPurchases Purch = new frmPurchases();
            Purch.TopLevel = false;
            Purch.Parent = pnlFORMS;
            Purch.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 123, 168);
            pnlReports.BackColor = Color.FromArgb(50, 168, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);
        }

        private void pnlReports_Click(object sender, EventArgs e)        // REPORTS panel click  
        {
            frmReports Reports = new frmReports();
            Reports.TopLevel = false;
            Reports.Parent = pnlFORMS;
            Reports.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 123, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);
        }

        private void lblReports_Click(object sender, EventArgs e)        // REPORTS label click  
        {
            frmReports Reports = new frmReports();
            Reports.TopLevel = false;
            Reports.Parent = pnlFORMS;
            Reports.Show();
            pnlGrowth.BackColor = Color.FromArgb(50, 168, 168);
            pnlPurchases.BackColor = Color.FromArgb(50, 168, 168);
            pnlReports.BackColor = Color.FromArgb(50, 123, 168);
            pnlSales.BackColor = Color.FromArgb(50, 168, 168);
        }
    }

}
