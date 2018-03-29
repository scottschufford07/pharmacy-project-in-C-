using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class InvoiceInfoClass
    {
        private string customerName;
        private int invoice;
        private int date;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public int Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }        
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        public InvoiceInfoClass()
        {
            customerName="";
            invoice=0;
            date=0;
        }
    }
}
