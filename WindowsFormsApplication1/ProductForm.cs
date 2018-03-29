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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void P_EXbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatagoryTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PackingTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchasePTxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalePtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ProductClass os = new ProductClass();
            try
            {
                os.Name = NameTxt.Text.Trim();
                os.Company = CompanyTxt.Text.Trim();
                os.Catagory = CatagoryTxt.Text;
                os.Packing = PackingTxt.Text;
                os.Purchaseprice = PurchasePTxt1.Text;
                os.Saleprice = SalePtxt.Text;
                // QueryClass.InsertData(fs);
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void EditTxt_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
