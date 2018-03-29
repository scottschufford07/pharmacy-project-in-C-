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
    public partial class CompanyInformation : Form
    {
        public CompanyInformation()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CompanyInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.CompanyInfoTable' table. You can move, or remove it, as needed.
            this.companyInfoTableTableAdapter.Fill(this.databaseDataSet.CompanyInfoTable);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCell_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
             CompanyInformationClass ss = new CompanyInformationClass();
            try
            {
                ss.Name=textname.Text.Trim();
                ss.Address = txtAddress.Text.Trim();
                ss.Cell = Convert.ToInt32(txtPhone.Text.Trim());
                ss.PhoneNo=Convert.ToInt32(txtCell.Text.Trim());
                 QueryClass.InsertData(ss);
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }

        private void dgCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
              CompanyInformationClass s = new CompanyInformationClass();
            try
            {
                s.Name=textname.Text.Trim();
                s.Address = txtAddress.Text;
                 QueryClass.DeleteData(s);
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        }
        
        }

