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
    public partial class BuyItems : Form
    {
        public BuyItems()
        {
            InitializeComponent();
        }

        private void BuyItems_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantitytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BuyItemClass ss = new BuyItemClass();
            try
            {
                ss.Name=Nametxt.Text.Trim();
                ss.Quantity = Quantitytxt.Text.Trim();
                ss.Expiry = textBox10.Text;
                 QueryClass.InsertData(ss);
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

     
        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
              BuyItemClass s = new BuyItemClass();
            try
            {
                s.Name=Nametxt.Text.Trim();
                s.Expiry = textBox10.Text;
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
