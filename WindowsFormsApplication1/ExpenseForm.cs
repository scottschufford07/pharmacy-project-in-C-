using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ExpenseForm : Form
    {
        public ExpenseForm()
        {
            InitializeComponent();
        }

        private void ExpBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            ExpenseClass ss = new ExpenseClass();
            try
            {
                ss.Nameexpense=txtName.Text.Trim();
                ss.Rupees = txtRS.Text.Trim();
                ss.Date = datetextbox.Text;
                 QueryClass.InsertData(ss);
                MessageBox.Show("Add Successfully");

                



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpenseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ExpenseTable' table. You can move, or remove it, as needed.
            this.expenseTableTableAdapter.Fill(this.databaseDataSet.ExpenseTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
              ExpenseClass s = new ExpenseClass();
            try
            {
                s.Nameexpense=txtName.Text.Trim();
                s.Date = datetextbox.Text;
                 QueryClass.DeleteData(s);
                MessageBox.Show("Delete Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        }
    }
