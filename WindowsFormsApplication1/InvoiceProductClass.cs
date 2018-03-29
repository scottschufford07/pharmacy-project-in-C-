using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class InvoiceProductClass
    {
        private string productiD;
        private string quantity;
        private string totel;

        public string Totel
        {
            get { return totel; }
            set { totel = value; }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public string ProductId
        {
            get { return productiD; }
            set { productiD = value; }
        }

        public InvoiceProductClass()
      {
          productiD = "";
          quantity = "";
          totel= "";
      }
    }
}
