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
    public partial class SalesManInfo : Form
    {
        public SalesManInfo()
        {
            InitializeComponent();
        }

        private void SalesManInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.SalesManTable' table. You can move, or remove it, as needed.
            this.salesManTableTableAdapter.Fill(this.databaseDataSet2.SalesManTable);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SmNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void salesmanQualification_Click(object sender, EventArgs e)
        {

        }

        private void txtNameDel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgSalesman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Please Fill The Form Above.");


            }
            else
            {
                SalesManInfoClass ps = new SalesManInfoClass();
                try
                {
                    ps.Name = txtName.Text.Trim();
                    ps.Qualification = txtQualification.Text.Trim();
                    ps.City = txtCity.Text;
                    ps.Number = txtNumber.Text;
                    QueryClass.InsertData(ps);
                    MessageBox.Show("Add Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }
                

            }
        }

        private void salesmanshowBtn_Click(object sender, EventArgs e)
        {
            salesmanPanel.Visible = true;
        }
    }
}
