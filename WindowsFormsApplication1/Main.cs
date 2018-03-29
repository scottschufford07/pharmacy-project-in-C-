using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseForm PF = new PurchaseForm();
            PF.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SalesManInfo SMI = new SalesManInfo();
            SMI.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderTakerForm OTF = new OrderTakerForm();
            OTF.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesForm SF = new SalesForm();
            SF.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StockForm SF = new StockForm();
            SF.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CompanyInformation CI = new CompanyInformation();
            CI.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ExpenseForm EF = new ExpenseForm();
            EF.ShowDialog();

        }

        private void MainExtBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm ln = new LoginForm();
            ln.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm l1 = new LoginForm();
            l1.Show();
        }
    }
}