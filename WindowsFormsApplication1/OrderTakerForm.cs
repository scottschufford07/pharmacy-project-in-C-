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
    public partial class OrderTakerForm : Form
    {
        public OrderTakerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrderTakerForm_Load(object sender, EventArgs e)
        {

        }

        private void OTExBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OTInfoclass os = new OTInfoclass();
            try
            {
                os.Name = txtName.Text.Trim();
                os.CompanyName = txtcmpnyName.Text.Trim();
                os.CompanyNumber = txtNumber.Text;
                // QueryClass.InsertData(fs);
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcmpnyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OTInfoclass s = new OTInfoclass();
            try
            {
                s.Name = txtName.Text.Trim();
                s.CompanyName = txtcmpnyName.Text;
               // QueryClass.DeleteData(s);
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }
    }
}
