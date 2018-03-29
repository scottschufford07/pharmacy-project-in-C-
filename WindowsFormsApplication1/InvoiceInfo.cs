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
    public partial class InvoiceInfo : Form
    {
        public InvoiceInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvoiceInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             InvoiceInfoClass fs = new InvoiceInfoClass();
            try
            {
                fs.CustomerName=customerNameTextbox.Text.Trim();
                fs.Invoice = Convert.ToInt32(invoiceTextBox.Text.Trim());
                fs.Date = Convert.ToInt32(dateTextBox.Text.Trim());
                // QueryClass.InsertData(fs);
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
   }
}

