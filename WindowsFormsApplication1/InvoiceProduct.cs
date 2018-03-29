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
    public partial class InvoiceProduct : Form
    {
        public InvoiceProduct()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceProduct_Load(object sender, EventArgs e)
        {

        }


        private void Savebtn_Click(object sender, EventArgs e)
        {
              InvoiceProductClass ss = new InvoiceProductClass();
            try
            {
                ss.ProductId=textBox1Product.Text.Trim();
                ss.Quantity=textBoxQuantity.Text.Trim();
                ss.Totel = textBoxTotel.Text;
                 QueryClass.InsertData(ss);
                MessageBox.Show("Add Successfully");
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void textBox1Product_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void InvoiceProduct_Load_1(object sender, EventArgs e)
        {

        }
     }
}
