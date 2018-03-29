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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyItems BI = new BuyItems();
            BI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm PF = new ProductForm();
            PF.ShowDialog();
        }

        private void PExbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
